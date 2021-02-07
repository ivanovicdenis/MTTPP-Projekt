# MTTPP-Projekt

## Testiranje rada stranice https://www.calculator.net/
### Izvršeno je parcijalno testiranje frontenda i backenda stranice
* Testirano je otvaranje svih pojednih konvertera koji se nalaze na homepageu stranice
* Testiran search bar stranice
* Testiran je rad komponente RandomNumberGenerator
* Testiran je rad komponente AgeCalculator koji računa godine osobe za određeni datum
* Testirana je komponenta LenghtConverter detaljno tako što je testirana točnost računanja kovenrzije centimetara u ostale mjerne duljine

## Upute za pokretanje testova

#### Testovi su pisani u C# programskom jeziku korištenjem NUnit Frameworka i Selenium WebDriver
#### Testovi su implementirani u VisaulStudio 2019 programu

### Programi koje je potrebno imati na računalu:
* VisualStudio 2019 (ili noviji)
* Firefox Browser

### Pokretanje testova:
1. Klonirajte repozitorij sa linka https://github.com/ivanovicdenis/MTTPP-Projekt.git
2. Pokrenuti **TestiranjeProjekt.sln** datoteku
3. Pokrenuti testove klikom na **Run All Test** unutar **Test** (Test->Run All Tests)
4. Ako želimo pokrenuti pojedinačno neki test otvorimo **Test Explorer** unutar **Test** (Test->Test Explorer)

### Dodavanje paketa
#### Ukoliko se iz nekog razloga nisu automatski dodali paketi koji se nalaze u *packages* folderu na repozitoriju potrebo ih je ručno intalirati
1. Kliknemo na **Manage NuGet Packages** unutar taba **Project** (Project->ManageNuGet Packages)
2. Kliknemo na prvi tab **Browse**
3. Pojedinačno nađemo i instaliramo slijedeće pakete:
	* NUnit
	* NUnit3TestAdapter
	* Selenium Support
	* Selenium WebDriver
	* Selenium WebDriver Gecko Driver