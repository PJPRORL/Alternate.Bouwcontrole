// Menu op kleine schermen en de filters op de pagina's met regels en taken.
(function () {
  var knop = document.getElementById("menu-knop");
  var site = document.querySelector(".site");
  if (knop && site) {
    knop.addEventListener("click", function () {
      var open = site.classList.toggle("menu-open");
      knop.setAttribute("aria-expanded", open ? "true" : "false");
    });
  }

  document.querySelectorAll("[data-filter]").forEach(function (blok) {
    var items = Array.prototype.slice.call(blok.querySelectorAll("[data-item]"));
    var zoek = blok.querySelector("input[type=search]");
    var keuze = blok.querySelector("select");
    var chips = Array.prototype.slice.call(blok.querySelectorAll(".chipknop"));
    var teller = blok.querySelector(".teller");
    var leeg = blok.querySelector(".leeg");
    var groepen = Array.prototype.slice.call(blok.querySelectorAll("[data-groep]"));

    function toepassen() {
      var tekst = zoek ? zoek.value.trim().toLowerCase() : "";
      var gekozen = keuze ? keuze.value : "";
      var actief = chips.filter(function (c) { return c.getAttribute("aria-pressed") === "true"; }).map(function (c) { return c.dataset.waarde; });
      var zichtbaar = 0;
      items.forEach(function (it) {
        var ok = true;
        if (tekst && it.textContent.toLowerCase().indexOf(tekst) === -1) ok = false;
        if (gekozen && (" " + it.dataset.onderdelen + " ").indexOf(" " + gekozen + " ") === -1) ok = false;
        if (actief.length && actief.indexOf(it.dataset.chip) === -1) ok = false;
        it.hidden = !ok;
        if (ok) zichtbaar++;
      });
      groepen.forEach(function (g) {
        g.hidden = !g.querySelector("[data-item]:not([hidden])");
      });
      if (teller) teller.textContent = zichtbaar + " van " + items.length + " getoond";
      if (leeg) leeg.hidden = zichtbaar !== 0;
    }

    chips.forEach(function (c) {
      c.addEventListener("click", function () {
        c.setAttribute("aria-pressed", c.getAttribute("aria-pressed") === "true" ? "false" : "true");
        toepassen();
      });
    });
    if (zoek) zoek.addEventListener("input", toepassen);
    if (keuze) keuze.addEventListener("change", toepassen);
    toepassen();
  });
})();
