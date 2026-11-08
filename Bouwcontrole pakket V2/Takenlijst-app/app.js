// Takenlijst Bouwcontrole V3: afvinken, notities en back-up. De voortgang blijft in deze browser.
(function () {
  const SLEUTEL = "takenlijst-bouwcontrole-v3";
  const D = TAKENLIJST;
  let staat = { vinkjes: {}, notities: {}, verbergKlaar: false };
  let opslagWerkt = true;

  function laden() {
    try {
      const ruw = localStorage.getItem(SLEUTEL);
      if (ruw) staat = Object.assign(staat, JSON.parse(ruw));
    } catch (e) {
      opslagWerkt = false;
    }
  }
  function bewaren() {
    try {
      localStorage.setItem(SLEUTEL, JSON.stringify(staat));
    } catch (e) {
      opslagWerkt = false;
      document.getElementById("opslag-melding").classList.remove("verborgen");
    }
  }

  const el = (tag, klasse, tekst) => {
    const e = document.createElement(tag);
    if (klasse) e.className = klasse;
    if (tekst !== undefined) e.textContent = tekst;
    return e;
  };

  function tabel(kop, rijen) {
    const wrap = el("div", "tabel-wrap");
    const t = el("table");
    const thead = el("thead");
    const tr = el("tr");
    kop.forEach((k) => tr.appendChild(el("th", "", k)));
    thead.appendChild(tr);
    t.appendChild(thead);
    const tbody = el("tbody");
    rijen.forEach((r) => {
      const rij = el("tr", r[0].toLowerCase().endsWith("samen") ? "samen" : "");
      r.forEach((c) => rij.appendChild(el("td", "", c)));
      tbody.appendChild(rij);
    });
    t.appendChild(tbody);
    wrap.appendChild(t);
    return wrap;
  }

  function lijst(items) {
    const ul = el("ul");
    items.forEach(([vet, rest]) => {
      const li = el("li");
      if (vet) li.appendChild(el("strong", "", vet + " "));
      li.appendChild(document.createTextNode(rest));
      ul.appendChild(li);
    });
    return ul;
  }

  function tijdTekenen() {
    const doel = document.getElementById("tijd-inhoud");
    doel.appendChild(el("p", "noot", "Gerekend met 6 uur per week, en 10 uur in de twee vakantieweken."));
    doel.appendChild(el("h3", "", "Oordeel"));
    doel.appendChild(lijst(D.OORDEEL.map(([k, v]) => [k + ":", v])));
    doel.appendChild(el("h3", "", "Mijlpalen"));
    doel.appendChild(tabel(D.MIJLPALEN_KOP, D.MIJLPALEN));
    doel.appendChild(el("p", "noot", D.MIJLPALEN_NOOT));
    doel.appendChild(el("h3", "", "Kalender"));
    doel.appendChild(tabel(D.KALENDER_KOP, D.KALENDER));
    doel.appendChild(el("p", "noot", D.KALENDER_NOOT));
    doel.appendChild(el("h3", "", "Waar de rem zit"));
    doel.appendChild(lijst(D.REM));
    doel.appendChild(el("h3", "", "Hoe gerekend"));
    doel.appendChild(lijst(D.HOE.map((h) => ["", h])));
    doel.appendChild(el("h3", "", "Uren per fase"));
    doel.appendChild(tabel(D.FASEN_KOP, D.FASEN));
    doel.appendChild(el("p", "noot", D.FASEN_NOOT));
  }

  function takenTekenen() {
    const doel = document.getElementById("taken");
    const nav = document.getElementById("secties");
    D.SECTIES.forEach((s) => {
      const a = el("a", "", s.code + " · " + s.titel.split(" · ")[0]);
      a.href = "#sectie-" + s.code;
      a.appendChild(el("span", "", ""));
      a.dataset.code = s.code;
      nav.appendChild(a);

      const sec = el("section", "sectie");
      sec.id = "sectie-" + s.code;
      const kop = el("div", "sectie-kop");
      kop.appendChild(el("h2", "", s.code + " · " + s.titel));
      const teller = el("span", "sectie-teller");
      teller.dataset.code = s.code;
      kop.appendChild(teller);
      sec.appendChild(kop);
      sec.appendChild(el("p", "sectie-intro", s.intro));

      s.groepen.forEach((g) => {
        sec.appendChild(el("h3", "", g.kop));
        g.taken.forEach((tk) => sec.appendChild(taak(tk)));
      });
      doel.appendChild(sec);
    });
  }

  function taak(tk) {
    const rij = el("div", "taak");
    rij.dataset.code = tk.code;
    const vak = el("input");
    vak.type = "checkbox";
    vak.id = "taak-" + tk.code;
    vak.checked = !!staat.vinkjes[tk.code];
    const titel = el("label", "taak-titel");
    titel.htmlFor = vak.id;
    titel.appendChild(el("span", "taak-code", tk.code));
    titel.appendChild(document.createTextNode(tk.titel));
    const uitleg = el("div", "taak-uitleg");
    uitleg.appendChild(document.createTextNode(tk.waarom + " "));
    uitleg.appendChild(el("span", "taak-bron", "(" + tk.bron + ")"));

    const notitieKnop = el("button", "taak-notitie-knop", staat.notities[tk.code] ? "Notitie" : "Notitie toevoegen");
    notitieKnop.type = "button";
    const notitie = el("textarea", "taak-notitie");
    notitie.value = staat.notities[tk.code] || "";
    notitie.placeholder = "Antwoord, beslissing of opmerking";
    if (!notitie.value) notitie.classList.add("verborgen");

    vak.addEventListener("change", () => {
      if (vak.checked) staat.vinkjes[tk.code] = new Date().toISOString().slice(0, 10);
      else delete staat.vinkjes[tk.code];
      rij.classList.toggle("klaar", vak.checked);
      bewaren();
      tellen();
    });
    notitieKnop.addEventListener("click", () => {
      notitie.classList.toggle("verborgen");
      if (!notitie.classList.contains("verborgen")) notitie.focus();
    });
    notitie.addEventListener("input", () => {
      if (notitie.value.trim()) staat.notities[tk.code] = notitie.value;
      else delete staat.notities[tk.code];
      notitieKnop.textContent = staat.notities[tk.code] ? "Notitie" : "Notitie toevoegen";
      bewaren();
    });

    rij.classList.toggle("klaar", vak.checked);
    rij.append(vak, titel, uitleg, notitieKnop, notitie);
    return rij;
  }

  function tellen() {
    let alles = 0, klaar = 0;
    D.SECTIES.forEach((s) => {
      let n = 0, k = 0;
      s.groepen.forEach((g) => g.taken.forEach((tk) => { n++; if (staat.vinkjes[tk.code]) k++; }));
      alles += n; klaar += k;
      document.querySelectorAll('.sectie-teller[data-code="' + s.code + '"]').forEach((e) => (e.textContent = k + " van " + n + " klaar"));
      document.querySelectorAll('.secties a[data-code="' + s.code + '"] span').forEach((e) => (e.textContent = k + "/" + n));
    });
    document.getElementById("totaal-klaar").textContent = klaar;
    document.getElementById("totaal-alles").textContent = alles;
    document.getElementById("totaal-balk").style.width = (alles ? Math.round((klaar / alles) * 100) : 0) + "%";
  }

  function allesOpnieuwTekenen() {
    document.getElementById("taken").innerHTML = "";
    document.getElementById("secties").innerHTML = "";
    takenTekenen();
    tellen();
  }

  function backupOpslaan() {
    const inhoud = {
      takenlijst: "Takenlijst Bouwcontrole",
      versie: 3,
      opgeslagen: new Date().toISOString(),
      vinkjes: staat.vinkjes,
      notities: staat.notities,
    };
    const blob = new Blob([JSON.stringify(inhoud, null, 2)], { type: "application/json" });
    const a = document.createElement("a");
    a.href = URL.createObjectURL(blob);
    a.download = "Back-up takenlijst Bouwcontrole " + new Date().toISOString().slice(0, 10) + ".json";
    document.body.appendChild(a);
    a.click();
    a.remove();
  }

  function backupTerugzetten(bestand) {
    const lezer = new FileReader();
    lezer.onload = () => {
      try {
        const b = JSON.parse(lezer.result);
        if (b.takenlijst !== "Takenlijst Bouwcontrole" || typeof b.vinkjes !== "object") {
          alert("Dit bestand is geen back-up van de takenlijst Bouwcontrole.");
          return;
        }
        if (b.versie !== 3) {
          alert("Dit is een back-up van een andere versie van de takenlijst. De taken van V3 zijn anders genummerd.");
          return;
        }
        if (false) {
          alert("Dit bestand is geen back-up van de takenlijst Bouwcontrole.");
          return;
        }
        if (!confirm("Je huidige vinkjes en notities worden vervangen door die uit de back-up. Doorgaan?")) return;
        staat.vinkjes = b.vinkjes || {};
        staat.notities = b.notities || {};
        bewaren();
        allesOpnieuwTekenen();
      } catch (e) {
        alert("Dit bestand kon niet gelezen worden.");
      }
    };
    lezer.readAsText(bestand);
  }

  // Start
  laden();
  if (!opslagWerkt) document.getElementById("opslag-melding").classList.remove("verborgen");
  document.getElementById("ondertitel").textContent = D.ONDERTITEL;
  document.getElementById("regel").textContent = D.REGEL;
  document.getElementById("bronnen").textContent = D.BRONNEN;
  tijdTekenen();
  takenTekenen();
  tellen();

  const verberg = document.getElementById("verberg-klaar");
  verberg.checked = !!staat.verbergKlaar;
  document.body.classList.toggle("verberg-klaar", verberg.checked);
  verberg.addEventListener("change", () => {
    staat.verbergKlaar = verberg.checked;
    document.body.classList.toggle("verberg-klaar", verberg.checked);
    bewaren();
  });

  document.getElementById("backup-opslaan").addEventListener("click", backupOpslaan);
  const invoer = document.getElementById("backup-bestand");
  document.getElementById("backup-terug").addEventListener("click", () => invoer.click());
  invoer.addEventListener("change", () => {
    if (invoer.files[0]) backupTerugzetten(invoer.files[0]);
    invoer.value = "";
  });
  document.getElementById("alles-wissen").addEventListener("click", () => {
    if (!confirm("Alle vinkjes en notities wissen? Maak eerst een back-up als je twijfelt.")) return;
    staat.vinkjes = {};
    staat.notities = {};
    bewaren();
    allesOpnieuwTekenen();
  });
})();
