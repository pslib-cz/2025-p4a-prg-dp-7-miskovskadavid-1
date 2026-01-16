# Aukční Systém

## Architektura a Návrhový Vzor

### Zvolený přístup
Pro splnění požadavků na nezávislost předmětu aukce (`AuctionItem`) a jednotlivých zájemců (`Bidder`) byl zvolen přístup založený na **rozhraních (Interfaces)**. Tento přístup zajišťuje:

*   **Nezávislost (Decoupling):** Předmět nezná konkrétní implementaci zájemců, komunikuje s nimi výhradně přes rozhraní `IObserver`.
*   **Flexibilitu:** Nové typy zájemců (např. automatické logování, mobilní notifikace) lze přidat bez nutnosti upravovat kód předmětu.
*   **Dynamickou správu:** Zájemci se mohou přihlašovat a odhlašovat kdykoliv během běhu aplikace.

### Použitý Návrhový Vzor: Observer (Pozorovatel)
Aplikace využívá návrhový vzor **Observer** (Behavioral pattern), který definuje závislost jeden-ku-mnoha mezi objekty tak, že změna stavu jednoho objektu vyvolá automatickou notifikaci a aktualizaci všech závislých objektů.

**Implementace v projektu:**
1.  **Subject (Předmět):** Třída `AuctionItem` implementuje rozhraní `ISubject`. Spravuje seznam pozorovatelů a při změně ceny (metoda `Notify`) je informuje.
2.  **Observer (Pozorovatel):** Třída `Bidder` implementuje rozhraní `IObserver`. Obsahuje metodu `Update`, která reaguje na změnu stavu předmětu.
