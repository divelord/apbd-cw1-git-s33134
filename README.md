# apbd-cw1-git-s33134

Repozytorium zawiera zadania wykonane na ćwiczeniach z przedmiotu APBD

## Odpowiedzi do pytań

_Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?_

Git wykona fast-forward, gdy wykonamy merge gałęzi x na main'a, który nie ma nowych commit'ów.  
Natomiast merge commit powstanie, gdy przed wykonaniem merge'a, powstanie nowy commit na main.

_Czym w praktyce różni się merge od rebase?_

Używając merge, commit'y gałęzi x są unikatowe dla tej gałęzi, a marge gałęzi tworzy tylko nowego commit'a (chyba, że był fast-forward to nie będzie merge commit).  
Natomiast używając rebase, commit'y z gałęzi x są kopiowane i przechodzą na główną gałęź. 

*W jaki sposób został rozwiązany konflikt w Twoim repozytorium?*

Poprzez kliknicie w "Resolve conflicts" sprawdziłem, która wersja kodu wg mnie jest bardziej przejrzysta i wybrałem czytelniejszą, upewniając się, że kod będzie działał poprawnie.