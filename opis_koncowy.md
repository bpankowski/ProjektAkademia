Założeniem projektu było stworzenie podręcznego "zeszytu na przepisy" i tak powstał Przepisomat (nazwa robocza).
film -> https://youtu.be/lRbaHFipEhI

Podczas realizacji projektu nie natknąłem się na większe problemy, jednak projekt cały czas jest w prostej formie do tego rozwojowej.

Użyta technologia WPF pasuje idealnie do projektu jak i zaprezentowanych rozwiązań, które zostały zrealizowane zgodnie z opisem wstępnym.

Poprzez dziedziczenie po bibliotece sqlite dostałem dostęp do bazy danych, której potrzebowałem najbardziej w tym projekcie, ponieważ takie było główne założenie by przepisy gdzieś przetrzymywać. Teraz dzięki jej konstrukcji można udoskonalać projekt dzięki poszerzaniu zebranej 'wiedzy' w bazie.

Stworzyłem okno logowania, może nie potrzebne jednak wiemy jak wszyscy pilnie strzega swych przepisów stwierdziłem że jest to miły dodatek i zostawiłem z pewnymi ograniczeniami w niezmienionej formie.
Główne okno programu. Zależało mi na funkcjonalności która zadeklarowałem zrealizować i tak znajdują się tutaj textboxy które muszą zostać wypełnione by później zapisac je w naszej bazie danych. Na podobnej relacji działają przyciski update jak i delete tzn. zapytania do bazy danych które później zostaja przez nią przetworzone. Po lewej znajduje się panel szybkiego poruszania sie po programie jak i opcja druku. Opcja druku polega na wykorzystaniu funkcjonalnosci WPF'a która daje możliwośc rzutowania Canvasu z gridu i jego późniejszy druk.

All recipes. Jest to okno pozwalajace na szybki dostep do bazy danych naszych przepisow. Zajdują się tutaj nasze wszystkie rekordy dań jak i zapisanych na short liscie składników. Łatwy i szybki dostęp jak i druk.

Shopping list. Założenie bylo takie by idąc na zakupy nie brać ze sobą nie potrzebnych informacji. tzn same składniki które potrzebujemy są wystarczającym materiałem dla nas. Dzięki temu z comboxa wybieramy przepis który nas interesuje dostajemy z bazy zapisane składniki i możemy dodać do tego nowe, które np po prostu przydadza nam się w domu / skonczyly sie itp. Poszukałem troche po eventach i dzięki temu możemy nie tylko dodatkowe skladniki wybrac z naszej bazy danych ale również dopisac własne na które mamy ochotę, super sprawa i przyjemna dla użytkowników. ( a przyjamniej wedlug mnie ;)).

Projekt może nie jest duży jednak uważam go za zrealizowanego według początkowych założeń nowej dla mnie technologii i jest przyjemny dla użytkownika co jest chyba jego największym plusem. 
