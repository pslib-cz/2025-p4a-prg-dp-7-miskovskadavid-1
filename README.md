# Aukční systém - Návrhový vzor Observer

Tento projekt implementuje jádro aukčního systému s využitím návrhového vzoru **Observer** (Pozorovatel).

## Proč byl zvolen tento přístup?

Zadání vyžadovalo, aby předmět aukce (dražená věc) nebyl závislý na konkrétních třídách zájemců a aby bylo možné přidávat nebo odebírat odběratele notifikací za běhu bez úpravy kódu předmětu.

Tento přístup byl zvolen z následujících důvodů:
- **Volná vazba (Loose Coupling):** Předmět (`AuctionItem`) komunikuje se zájemci pouze přes obecné rozhraní `IAuctionObserver`. Nezná konkrétní třídu `Bidder`.
- **Dynamičnost:** Seznam odběratelů není fixní. Zájemci se mohou kdykoliv přihlásit (`Attach`) nebo odhlásit (`Detach`).
- **Princip OCP (Open/Closed Principle):** Systém je otevřený pro rozšíření (např. nové typy zájemců, logování, mobilní notifikace) bez nutnosti měnit kód předmětu.

## Použitý návrhový vzor

**Observer (Pozorovatel)**

Tento vzor definuje závislost typu *jeden ku mnoha* (1:N) mezi objekty tak, že změna stavu jednoho objektu (Předmět) vyvolá automatickou aktualizaci všech závislých objektů (Pozorovatelé).

### Implementace

Implementace se skládá ze tří hlavních částí:
1.  **`IAuctionObserver` (Rozhraní):** Kontrakt, který musí splňovat každý, kdo chce být informován o změně ceny.
2.  **`AuctionItem` (Subject):** Drží si seznam pozorovatelů a při změně ceny (`Price`) volá metodu `Notify()`, která rozešle informaci všem v seznamu.
3.  **`Bidder` (Concrete Observer):** Konkrétní implementace zájemce, který na notifikaci reaguje výpisem do konzole.
 
 
