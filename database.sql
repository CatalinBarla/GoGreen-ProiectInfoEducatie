-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 17, 2026 at 11:05 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database`
--

-- --------------------------------------------------------

--
-- Table structure for table `achievements`
--

CREATE TABLE `achievements` (
  `PuncteCarbon` int(100) NOT NULL,
  `PuncteKcal` int(100) NOT NULL,
  `PunctePoster` int(100) NOT NULL,
  `PuncteLectii` int(100) NOT NULL,
  `PuncteMeteo` int(100) NOT NULL,
  `PuncteCulori` int(100) NOT NULL,
  `EmailUtilizator` char(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `achievements`
--

INSERT INTO `achievements` (`PuncteCarbon`, `PuncteKcal`, `PunctePoster`, `PuncteLectii`, `PuncteMeteo`, `PuncteCulori`, `EmailUtilizator`) VALUES
(15, 15, 20, 10, 15, 15, 'andrei@gmail.com'),
(15, 15, 20, 20, 15, 15, 'anto@gmail.com'),
(0, 0, 0, 10, 0, 15, 'catalin@gmail.com'),
(15, 15, 20, 20, 15, 15, 'Citu@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `intrebari`
--

CREATE TABLE `intrebari` (
  `ID` int(5) NOT NULL,
  `Capitol` char(100) NOT NULL,
  `Lectie` char(100) NOT NULL,
  `Enunt` char(100) NOT NULL,
  `ra` char(100) NOT NULL,
  `rb` char(100) NOT NULL,
  `rc` char(100) NOT NULL,
  `RaspunsCorect` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `intrebari`
--

INSERT INTO `intrebari` (`ID`, `Capitol`, `Lectie`, `Enunt`, `ra`, `rb`, `rc`, `RaspunsCorect`) VALUES
(1, 'C1', 'L1', 'Care dintre următorii factori externi declanșează biologic migrația păsărilor?', 'a.Modificarea lungimii zilei luminoase', 'b.Scăderea temperaturii apei', 'c.Creșterea umidității aerului', 'a'),
(2, 'C1', 'L1', 'Ce sistem de navigare extrem de avansat folosesc păsările pe timp de noapte?', 'a.Orientarea bazată pe poziția lunii', 'b.Orientarea astronomică bazată pe poziția stelelor', 'c.Detectarea undelor radio emise de pământ', 'b'),
(3, 'C1', 'L1', 'Unde este localizat simțul magnetic intern (instrumentul de magnetorecepție) al păsărilor?', 'a.La nivelul aripilor și al picioarelor', 'b.La nivelul ochilor și al ciocului', 'c.La nivelul sistemului auditiv', 'b'),
(4, 'C1', 'L2', 'Ce reprezintă starea biologică de hiperfagie care apare înainte de migrație?', 'a.Un apetit exagerat ce determină consumul unor cantități uriașe de hrană', 'b.O perioadă de repaus total în care păsările nu se mișcă', 'c.O pierdere masivă în greutate pentru ușurarea zborului', 'a'),
(5, 'C1', 'L2', 'De ce este grăsimea subcutanată combustibilul ideal pentru zborul de lungă durată?', 'a.Este mai ușoară decât proteinele și oferă mai puține calorii', 'b.Oferă de două ori mai multă energie pe gram decât proteinele și eliberează apă prin ardere', 'c.Se dizolvă rapid în sânge fără să necesite oxigen', 'b'),
(6, 'C1', 'L2', 'Cum evită păsările mari precum berzele și pelicanii oboseala extremă provocată de darea continuă din', 'a.Zboară doar la altitudini foarte joase aproape de sol', 'b.Folosesc curenții termici ascendenți pentru a plana', 'c.Migrează exclusiv pe timp de noapte pentru răcorire', 'b'),
(7, 'C1', 'L3', 'De ce au păsările migratoare nevoie de refugii de odihnă și hrănire pe traseu?', 'a.Pentru a învăța rute noi de la păsările locale', 'b.Deoarece nu pot zbura mii de kilometri fără oprire și au nevoie să își refacă rezervele', 'c.Pentru a se adăposti de prădătorii aerieni pe timp de zi', 'b'),
(8, 'C1', 'L4', 'Ce reprezintă fenomenul de decalaj fenologic provocat de schimbările climatice?', 'a.Creșterea numărului de specii migratoare dintr-o anumită zonă', 'b.Perturbarea sincronizării perfecte dintre calendarul de migrație și ciclurile naturale ale naturii', 'c.Modificarea formei fizice a păsărilor pentru a rezista la temperaturi mari', 'b'),
(9, 'C1', 'L4', 'De ce apare înfometarea puietului de păsări migratoare în nord?', 'a.Deoarece păsările sosesc mai devreme decât plantele verzi', 'b.Deoarece la ieșirea puilor din ouă, perioada de maximă abundență a insectelor a trecut deja', 'c.Deoarece părinții refuză să mai caute hrană din cauza căldurii', 'b'),
(10, 'C1', 'L4', 'Cum afectează secetele prelungite rutele de zbor ale păsărilor migratoare?', 'a.Duc la dispariția zonelor umede, lăsând păsările fără apa și hrana necesare călătoriei', 'b.Determină apariția unor curenți de aer favorabili zborului rapid', 'c.Provoacă modificarea culorii penajului păsărilor', 'a'),
(11, 'C2', 'L1', 'Din ce zonă geografică este originar carasul (Carassius gibelio)?', 'a.Din America de Nord', 'b.Din Asia', 'c.Din Africa', 'b'),
(12, 'C2', 'L1', 'Cum supraviețuiește carasul în condiții extreme de îngheț sau secetă?', 'a.Migrează rapid spre izvoarele reci de munte', 'b.Se îngroapă adânc în mâlul moale de pe fundul apei și intră în torpoare metabolică', 'c.Își schimbă dieta devenind exclusiv prădător de suprafață', 'b'),
(13, 'C2', 'L1', 'De ce este carasul considerat un pește omnivor extrem de oportunist?', 'a.Deoarece consumă doar plante acvatice de la suprafața apei', 'b.Deoarece dieta sa versatilă include plante, alge, larve, viermi, crustacee și resturi organice', 'c.Deoarece vânează doar pești mari pe timp de noapte', 'b'),
(14, 'C2', 'L2', 'Unde trăiește exclusiv păstrăvul indigen (Salmo trutta fario) în România?', 'a.În apele adânci și leneșe ale fluviului Dunărea', 'b.În etajul montan superior, în râuri rapide de munte și lacuri alpine', 'c.În bazinele de irigații și bălțile joase de șes', 'b'),
(15, 'C2', 'L3', 'Care este cea mai distinctivă caracteristică fizică a somnului (Silurus glanis)?', 'a.Corpul acoperit cu solzi mari și strălucitori', 'b.Cele șase mustăți lungi, care sunt organi senzoriale sofisticate', 'c.Ochii uriași adaptați la lumina puternică', 'b'),
(16, 'C2', 'L3', 'Cum compensează somnul vederea sa slabă și ochii foarte mici?', 'a.Prin sistemul tactil de mustăți, detectarea vibrațiilor fine și un simț olfactiv dezvoltat', 'b.Prin capacitatea de a genera descărcări electrice puternice', 'c.Prin migrația zilnică spre apele limpezi de munte', 'a'),
(17, 'C2', 'L3', 'Ce tip de comportament și dietă are somnul?', 'a.Este un prădător solitar și nocturn, cu o dietă ce include pești, broaște, raci și chiar păsări', 'b.Este un pește pașnic și diurn care se hrănește doar cu alge', 'c.Este un pește care vânează în grupuri mari exclusiv pe timp de zi', 'a'),
(18, 'C2', 'L4', 'Ce se întâmplă cu oxigenul dizolvat din apele montane pe măsură ce acestea se încălzesc?', 'a.Concentrația de oxigen dizolvat crește semnificativ', 'b.Capacitatea apei de a reține oxigenul dizolvat scade dramatic, provocând asfixierea peștilor', 'c.Nivelul de oxigen rămâne constant indiferent de temperatură', 'b'),
(19, 'C2', 'L4', 'Ce înseamnă procesul de eutrofizare rapidă în zonele de șes pe timp de secetă?', 'a.Scăderea numărului de plante din jurul râurilor', 'b.Proliferarea algelor care consumă oxigenul rămas când se descompun', 'c.Curățarea naturală a apei prin sedimentarea mâlului', 'b'),
(20, 'C2', 'L4', 'Cum afectează lipsa viiturilor de primăvară reproducerea peștilor autohtoni?', 'a.Împiedică peștii să ajungă în zonele inundabile tradiționale pentru a-și depune icrele', 'b.Ajută la curățarea perfectă a pietrișului pe care se depun icrele', 'c.Nu are niciun impact asupra ciclurilor reproductive ale peștilor', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `lectii`
--

CREATE TABLE `lectii` (
  `Capitol` int(5) NOT NULL,
  `NumarLectie` int(5) NOT NULL,
  `Text` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lectii`
--

INSERT INTO `lectii` (`Capitol`, `NumarLectie`, `Text`) VALUES
(1, 1, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 1: Fenomenul migratiei pasarilor\\b0\\f0\\fs22\\par\\par Fenomenul migratiei pasarilor reprezinta una dintre cele mai fascinante si complexe manifestari ale lumii animale, fiind o strategie de supravietuire rafinata de-a lungul a milioane de ani de evolutie. In fiecare an, miliarde de pasari din intreaga lume parasesc zonele de reproducere pentru a calatori spre regiuni unde resursele de hrana sunt abundente in timpul sezonului rece.\\par\\par Acest impuls puternic nu este o simpla alegere, ci un mecanism biologic complex controlat genetic si declansat de o serie de factori externi bine sincronizati:\\par - Modificarea lungimii zilei luminoase\\par - Scaderea accentuata a temperaturilor\\par - Reducerea drastica a disponibilitatii hranei de baza\\par\\par Pentru a realiza aceste calatorii epice, care adesea depasesc mii sau chiar zeci de mii de kilometri peste continente si oceane, pasarile folosesc sisteme de navigatie uimitor de avansate. Ele combina memoria vizuala a peisajelor terestre, recunoscand cursuri mari de apa, lanturi muntoase si linii de coasta, cu orientarea astronomica bazata pe pozitia soarelui in timpul zilei si a stelelor pe timp de noapte.\\par\\par Mai mult decat atat, cercetarile stiintifice moderne au demonstrat ca pasarile poseda un \\b simt magnetic intern \\b0 remarcabil, o forma de magnetoreceptie situata la nivelul ochilor si al ciocului. Acest instrument biologic le permite sa simta direct liniile campului magnetic al Pamantului, actionand ca o busola naturala infailibila care le ghideaza cu precizie extrema chiar si in conditii de vizibilitate zero, prin ceata densa sau nori grosi. Aceasta harta interna complexa asigura ca grupurile revin an de an exact in aceleasi locuri specifice pentru a-si perpetua specia.}'),
(1, 2, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 2: Pregatirea fizica si managementul energiei\\b0\\f0\\fs22\\par\\par Pregatirea fizica pentru o calatorie de o asemenea anvergura necesita transformari fiziologice si anatomice radicale in corpul pasarilor migratoare. Cu cateva saptamani inainte de plecare, pasarile intra intr-o stare biologica numita \\b hiperfagie\\b0, un apetit exagerat care le determina sa consume cantitati uriase de hrana bogata in carbohidrati si grasimi.\\par\\par Acest surplus alimentar este transformat in depozite masive de grasime subcutanata, care pot ajunge sa reprezinte pana la jumatate din greutatea totala a corpului pasarii inainte de decolare. Grasimea este combustibilul ideal pentru zborul de lunga durata, oferind:\\par 1. De doua ori mai multa energie pe gram decat proteinele.\\par 2. Eliberarea de apa in procesul de ardere (previne deshidratarea).\\par\\par Managementul energiei in timpul zborului este o alta dovada de adaptare geniala. Multe specii mari, cum sunt berzele, pelicanii sau pasarile de prada, evita darea continua din aripi, care este extrem de obositoare. In schimb, ele folosesc curentii termici ascendenti, adica masele de aer cald care se ridica de la sol, pentru a plana si a castiga altitudine fara efort muscular considerabil.\\par\\par De asemenea, organizarea sociala joaca un rol critic. Zborul in celebra \\b formatie in forma de V\\b0, intalnit adesea la gaste si cocoori, creeaza un effect aerodinamic favorabil. Pasarea din frunte deschide calea si infrunta rezistenta maxima a aerului, in timp ce pasarile din spate beneficiaza de curentul ascendent generat de aripile celei din fata, reducand efortul general al stolului. Pasarile mici prefera adesea sa migreze exclusiv pe timp de noapte pentru a reduce riscul de supraincalzire.}'),
(1, 3, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 3: Rutele de migratie si importanta Deltei Dunarii\\b0\\f0\\fs22\\par\\par Succesul pe termen lung al migratiei nu depinde doar de abilitatile fizice ale pasarilor, ci si de existenta unei retele ecologice continue de habitate intacte de-a lungul intregului traseu geografic. Pasarile nu pot zbura mii de kilometri fara oprire, motiv pentru care au nevoie disperata de puncte strategice de stationare, cunoscute sub numele de \\b refugii de odihna si hranire\\b0.\\par\\par Aceste zone actioneaza ca niste statii de alimentare vitale pe autostrazile aeriene globale. In context european, Romania ocupa o pozitie geografica absolut cruciala, fiind situata la intersectia mai multor rute majore de migratie, cum sunt:\\par - Culoarul pontic\\par - Culoarul sarmatic\\par\\par Perla acestei retele este \\b Delta Dunarii\\b0, o zona umeda de importanta universala, recunoscuta ca un adevarat paradis si nod feroviar al pasarilor migratoare. Aici, sute de specii de pasari acvatice, printre care pelicani, starci, egrete si nenumatate tipuri de rate si gaste salbatice, gasesc o abundenta extraordinara de hrana formata din pesti, amfibieni si plante submerse, cruciala pentru refacerea rezervelor de energie epuizate.\\par\\par Totusi, dependenta de aceste locuri specifice transforma migratia intr-un proces extrem de vulnerabil la interventia omului. Distrugerea sau degradarea unui singur punct critic de oprire prin desecari de balti, agricultura intensiva, poluare chimica sau urbanizare fortata poate avea un efect de domino catastrofal. Daca pasarile sosesc epuizate intr-un refugiu traditional si gasesc acolo un mediu distrus, ele nu isi pot reface fortele si risca sa moara de foame inainte de a ajunge la destinatia finala.}'),
(1, 4, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 4: Impactul schimbarilor climatice asupra pasarilor\\b0\\f0\\fs22\\par\\par Schimbarea climatica provocata de activitatile umane reprezinta in prezent una dintre cele mai severe si insidioase amenintari la adresa pasarilor migratoare, destabilizand mecanismele ecologice stabilite de milenii. Principalul impact consta in perturbarea sincronizarii perfecte dintre calendarul de migratie si ciclurile naturale ale naturii, fenomen cunoscut sub numele de \\b decalaj fenologic\\b0.\\par\\par Din cauza cresterii globale a temperaturilor, primavara se instaleaza mult mai devreme in zonele de reproducere din nord. Plantele inverzesc mai repede, iar insectele, care constituie sursa principala de hrana pentru puii de pasari, isi ating varful de abundenta mult mai devreme decat in trecut.\\par\\par Pasarile migratoare sosesc adesea la destinatie conform vechiului calendar genetic. Acest decalaj temporal provoaca consecinte grave:\\par - Cand puii ies din oua, perioada de maxima abundenta a insectelor a trecut deja.\\par - Apare infometarea puietului.\\par - Se inregistreaza o scadere dramatica a succesului reproductiv.\\par\\par Pe langa aceasta desincronizare, schimbarile climatice intensifica frecventa si severitatea fenomenelor meteorologice extreme de-a lungul rutelor de zbor. Furtunile violente, vanturile puternice din sens opus si valurile de caldura extrema deviaza stolurile de la traseu si provoaca o mortalitate ridicata prin epuizare fizica completa. Secetele prelungite duc la disparitia zonelor umede, lasand pasarile fara apa si hrana necesare pentru a-si continua calatoria.}'),
(2, 1, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 1: Carasul (Carassius gibelio) - Campionul adaptabilitatii\\b0\\f0\\fs22\\par\\par Trecand la fauna acvatica din Romania, carasul reprezinta una dintre cele mai remarcabile si de succes specii de pesti de apa dulce care populeaza bazinele hidrografice ale tarii. Originar din Asia, dar perfect aclimatizat de peste un secol, carasul se gaseste in prezent in aproape toate tipurile de ecosisteme acvatice joase, de la balti si lacuri de ses, pana la canalele de irigatii si Delta Dunarii.\\par\\par Ceea ce face ca acest peste sa fie atat de raspandit este capacitatea sa biologica absolut fenomenala de adaptare si rezistenta la conditii de mediu extreme:\\par - \\b Oxigen scazut:\\b0 Supravietuieste in ape cu niveluri minime de oxigen, specifice verilor toride.\\par - \\b Rezistenta la inghet/seceta:\\b0 Are abilitatea unica de a se ingropa adanc in malul moale de pe fundul apei, intrand intr-o stare de torpoare metabolica pana la revenirea conditiilor normale.\\par\\par Din punct de vedere alimentar, este un peste omnivor extrem de oportunist si putin pretentios. Dieta sa versatila include plante acvatice, alge microscopice, larve de insecte, viermi, crustacee mici si diverse resturi organice descompuse. Aceasta flexibilitate alimentara totala, combinata cu o rezistenta de fier, ii asigura o supravietuire de succes si o dominatie clara in apele din Romania, devenind adesea specia majoritara in habitatele dificile unde alti pesti nu ar putea rezista.}'),
(2, 2, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 2: Pastravul indigen (Salmo trutta fario) - Aristocratul apelor de munte\\b0\\f0\\fs22\\par\\par In contrast total cu adaptabilitatea bruta a carasului, pastravul indigen reprezinta aristocratia apelor dulci din Romania, fiind un indicator biologic suprem al puritatii si sanatatii mediului inconjurator. Acest peste superb traieste exclusiv in etajul montan superior, populand raurile rapide de munte, paraiele cristaline cu fund pietros si lacurile alpine situate la altitudini mari in Carpati.\\par\\par Anatomia si fiziologia pastravului sunt proiectate perfect pentru viata intr-un mediu dinamic si exigent. Corpul sau hidrodynamic, musculos si acoperit cu puncte caracteristice negre si rosii, ii permite sa inoate impotriva curentilor extrem de puternici.\\par\\par Cerintele ecologice ale pastravului sunt extrem de rigide:\\par 1. \\b Temperatura apei:\\b0 Trebuie sa fie rece, sa nu depaseasca in mod ideal 14-16 grade Celsius vara.\\par 2. \\b Oxigenare:\\b0 Necesita o concentratie foarte mare de oxigen dizolvat in apa.\\par 3. \\b Claritate:\\b0 Apa trebuie sa fie perfect curata, lipsita de suspensii de mal sau poluanti.\\par\\par Procesul de reproducere reflecta aceste pretentii mari: in timpul toamnei, pastravii urca spre izvoare pentru a-si depune icrele exclusiv in zone cu pietris curat. Ca pradator vizual de top in ecosistemul montan, pastravul este extrem de agil. Hrana sa principala este formata din insecte acvatice in stadiu de larva, muste prinse la suprafata apei si pesti mai mici, atacul sau fiind fulgerator.}'),
(2, 3, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 3: Somnul (Silurus glanis) - Gigantul adancurilor\\b0\\f0\\fs22\\par\\par Coborand din zonele inalte spre cursurile mari de apa, intalnim somnul, cel mai mare si mai impunator peste de apa dulce din Romania si de pe intregul continent european. Acest gigant acvatic populeaza cu predilectie apele adanci, lenese si tulburi ale fluviului Dunarea, brațele sale secundare, lacurile mari de acumulare si sectoarele inferioare ale raurilor mari precum Muresul, Oltul, Siretul sau Prutul.\\par\\par Somnul este un peste cu un aspect inconfundabil, avand un corp masiv, lipsit de solzi si o gura uriasa inzestrata cu randuri de dinti marunti. Caracteristica sa cea mai distinctiva este reprezentata de cele \\b sase mustati lungi\\b0, care sunt organe senzoriale extrem de sofisticate.\\par\\par Deoarece traieste la adancimi mari, unde lumina soarelui abia patrunde, somnul are ochii foarte mici si o vedere slaba. El compenseaza acest deficit prin:\\par - Un sistem tactil extraordinar furnizat de mustati.\\par - Detectarea celor mai fine vibratii din apa.\\par - Un simt olfactiv dezvoltat pentru gasirea hranei in intuneric.\\par\\par Somnul este un pradator solitar si nocturn, care isi petrece ziua ascuns in gropi adanci sau sub trunchiuri de copaci scufundati. Odata cu lasarea intunericului, porneste la vanatoare, iar dieta sa include pesti mari, broaste, raci, rozatoare acvatice si chiar pasari care inoata la suprafata.}'),
(2, 4, '{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset0 Segoe UI;}{\\f1\\fnil\\fcharset0 Segoe UI Semibold;}}\\viewkind4\\uc1\\b\\f1\\fs28 LECTIA 4: Impactul schimbarilor climatice asupra pestilor autohtoni\\b0\\f0\\fs22\\par\\par Schimbarea climatica exercita o presiune uriasa si adesea invizibila asupra ecosistemelor acvatice din Romania, amenintand in mod direct supravietuirea speciilor de pesti autohtoni prin alterarea fizica si chimica a habitatelor lor. Efectul cel mai distructiv este cresterea constanta a temperaturii medii a apelor de suprafata in timpul verii.\\par\\par Acest fenomen afecteaza in mod critic speciile iubitoare de frig, cum este pastravul indigen. Pe masura ce apele montane se incalzesc, capacitatea apei de a reține oxigenul dizolvat scade dramatic, provocand asfixierea pestilor. Pastravii sunt fortati sa migreze spre altitudini tot mai mari, unde habitatele sunt insa mai stramte, ducand la izolarea populatiilor.\\par\\par In zonele de ses, schimbarile climatice se manifesta prin secete prelungite, determinand:\\par - Scaderea severa a debitelor raurilor.\\par - Secarea completa a baltilor si canalelor secundare.\\par - \\b Eutrofizarea rapida:\\b0 Proliferarea algelor care consuma oxigenul ramas cand se descompun.\\par\\par In aceste bazine reduse, apa se supraincalzeste si concentreaza poluanti chimici, declansand mortalitati piscicole in masa. Chiar si specii rezistente precum somnul sau carasul au de suferit. Mai mult, lipsa viiturilor de primavara impiedica pestii sa ajunga in zonele inundabile traditionale pentru a-si depune icrele, blocand ciclurile naturale de reproducere.}');

-- --------------------------------------------------------

--
-- Table structure for table `utilizatori`
--

CREATE TABLE `utilizatori` (
  `ID` int(5) NOT NULL,
  `Nume` char(100) NOT NULL,
  `Email` char(100) NOT NULL,
  `Parola` char(100) NOT NULL,
  `DataInregistrare` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `utilizatori`
--

INSERT INTO `utilizatori` (`ID`, `Nume`, `Email`, `Parola`, `DataInregistrare`) VALUES
(1, 'Satmar Andrei', 'andrei@gmail.com', '96cae35ce8a9b0244178bf28e4966c2ce1b8385723a96a6b838858cdd6ca0a1e', '13/07/2026'),
(2, 'Barla Catalin', 'catalin@gmail.com', '96cae35ce8a9b0244178bf28e4966c2ce1b8385723a96a6b838858cdd6ca0a1e', '15/07/2026'),
(3, 'Barla Antonia', 'anto@gmail.com', '96cae35ce8a9b0244178bf28e4966c2ce1b8385723a96a6b838858cdd6ca0a1e', '17/07/2026'),
(4, 'CituBarla', 'Citu@gmail.com', '96cae35ce8a9b0244178bf28e4966c2ce1b8385723a96a6b838858cdd6ca0a1e', '17/07/2026');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `achievements`
--
ALTER TABLE `achievements`
  ADD PRIMARY KEY (`EmailUtilizator`);

--
-- Indexes for table `intrebari`
--
ALTER TABLE `intrebari`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `utilizatori`
--
ALTER TABLE `utilizatori`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `intrebari`
--
ALTER TABLE `intrebari`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `utilizatori`
--
ALTER TABLE `utilizatori`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
