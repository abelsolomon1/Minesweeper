# UserStories und Akzeptanzkriterien

---

#### UserStorie1

Als Spieler möchte ich die Möglichkeit haben, die Feldgrösse auszuswählen, damit ich verschiedene Schwierigkeitsstufen habe.

##### Akzeptanzkriterien

    1. Das Spiel enthält eine Auswahl zwischen drei verschiedenen Feldgrössen.

    2. Das Spiel stellt bei der Auswahl dar, wie gross das jeweilige Feld ist und wie viele         Bomben dieses Feld enthält.

    3. Das Spiel soll das ausgewählte Spielfeld richtig generieren.

    4. Das Spiel soll drei unterschiedlich schwere Modi haben.(Einfach, Mittel, Schwer)

**Tasks**

- [ ]  Feldgrösse muss implementiert werden mit Funktionen die gefordert sind

- [ ] Anzeige der Bomben für das jeweilige Schwierigkeitsgrad implementieren

---

#### UserStorie2

Als Spieler möchte ich die Möglichkeit haben, meine gebrauchte Spielzeit zu sehen, damit ich sehe ob ich gut in der Zeit liege.

##### Akzeptanzkriterien

    1. Das Spiel soll eine Stopuhr anzeigen.

    2. Die Stopuhr soll genau zum Zeitpunkt des beenden des Spieles gestoppt werden.

    3. Die Stopuhr soll auch während des Spieles angezeigt werden.

    4. Die Stopuhr soll im Sekundentakt aktualisiert werden.

**Tasks**

- [ ] Stoppuhr implementieren mit richtigen Funktionen

- [ ] Stoppuhr während des Spieles anzeigen lassen.

---

#### UserStorie3

Als Spieler möchte ich die Möglichkeit haben, Spielzüge Rückgängig zu machen, damit ich nicht immer von vorne beginnen muss.

##### Akzeptanzkriterien

    1. Das Spiel soll eine Taste beinhalten, mit der man den letzten Spielzug Rückgängig         machen kann.

    2. Das Spiel soll die Zeit beim Rückgängig machen nicht anhalten oder gar löschen.

    3. Im Menü soll angezeigt werden, welche Taste für das Rückgängig machen         zuständig ist.(R)

    4. Das Spiel gibt die Möglichkeit Rückgängig zu machen erst dann frei, wenn eine         Mine getroffen wurde.

**Tasks**

- [ ] Einen Stack erstellen für die Undo Funktion

- [ ] Undo Funktion gemäss eingabe "R" aufrufen lassen

- [ ] Funktion erst dann geben lassen wenn "Game over" angezeigt wird

---

#### UserStorie4

Als Spieler möchte ich die Möglichkeit haben jederzeit ein Menü aufzurufen, damit ich nachschauen kann wie das Spiel funktioniert und welche Tasten für was nötig sind.

##### Akzeptanzkriterien

    1. Im Menü soll angezeigt werden, welche Tasten welche Aktionen ausführen.

    2. Im Menü soll angezeigt werdem, wie das Spiel funktioniert(Kurzanleitung).

    3. Im Menü soll mein Highscore angezeigt werden, von der jetztigen Laufzeit des         Spieles.

    4. Das Menü soll durch eine Taste aufgerufen werden.

**Tasks**

- [ ] Menu erstellen die mit einer Taste aufgerufen werden kann

- [ ] Kurzanleitung für das Spiel erstellen und Tastenkombinationen überlegen

- [ ] Highscore speichern und auch im Menu anzeigen lassen

---

#### UserStorie5

Als Spieler möchte ich die Möglichkeit haben, meinen aktuellen Highscore zu sehen, damit ich mich selber verbessern kann

##### Akzeptanzkriterien

    1. Während dem Spiel soll neben dem jetztigen Score auch der Highscore angezeigt         werden.

    2. Der Highscore soll auch im Menü angezeigt werden.

    3. Der Highscore soll aktualisiert werden, sobald der alte übertroffen wurde.

    4. Wenn der Highscore übertroffen wurde soll eine Meldung kommen.

**Tasks**

- [ ] Score (Zeit)implementieren und anzeigen lassen

- [ ] Stack für einen Highscore überschreiben lassen falls man einen neuen Highscore hat

- [ ] Anzeige "Neuer Highscore" erstellen

---

#### UserStorie6

Als Spieler möchte ich die Möglichkeit haben, das Spiel zu pausieren, damit die Zeit nicht weiter läuft, wenn ich abgelenkt bin.

##### Akzeptanzkriterien

    1. Im Menü soll festgelegt sein, welche Taste für Pause ist.

    2. Die Taste soll jederzeit im Spiel betätigt werden können.

    3. Wenn die Taste gedrückt wird, soll das Spiel anhalten und der Timer gestoppt         werden

    4. Bei erneutem Drücken der Taste, soll dann das Spiel weitergehen und die Zeit         weiterlaufen.

**Tasks**

- [ ] Pausentaste implementieren (Taste P)

- [ ] "P" jederzeit aufrufbar machen können

- [ ] Timer stoppen Funktion erstellen

- [ ] Timer laufen lassen Funktion erstellen

---

#### UserStorie7

Als Spieler möchte ich die Möglichkeit haben, jederzeit nachlesen zu können, wie das Spiel funktioniert und was die Regeln des Spieles sind, damit ich das Spiel richtig spielen kann.

##### Akzeptanzkriterien

    1. Vor dem Spiel soll das Menü geöffnet sein, damit ich sehe welche Tasten ich für         was brauche.

    2. Die Regeln sollen jederzeit aufgerufen werden mit einer bestimmten Taste.

    3. Die Taste soll im Menü festgelegt sein.

    4. In den Regeln soll genau beschrieben sein welche Taste für was gebraucht wird         und wie das Spiel zu spielen ist.

**Tasks**

- [ ] Funktion erstellen damit das Menu am anfang des Speils angezeigt werden kann

- [ ] Funktion damit das Menu nach einer gewissen Zeit wieder verschwindet.

- [ ] Regeln für Tasten ausdenken.

- [ ] Taste um das Menu aufzurufen erstellen

---

#### UserStorie8

Als Spieler möchte ich die Möglichkeit haben, Felder mit Flaggen zu markieren, damit ich sehe wo sich Mienen befinden und ich mir das nicht im Kopf merken muss.

##### Akzeptanzkriterien

    1. Im Menü soll festgelegt sein, welche Taste für das markieren mit Flaggen ist.

    2. Die Flaggen sollen platziert aber auch wieder entfernt werden können.

    3. Die Flaggen sollen auch auf falschen Feldern platziert werden können.

    4. Die Flaggen sollen ein klar identifizier bares Zeichen verwenden.

**Tasks**

- [ ] Taste für das Markieren von Flaggen implementieren.

- [ ] Menubeschreibung der Regelung von der Taste der Flagge hinzufügen

- [ ] Anzeigen lassen ob ein Feld markiert wurde oder nicht

---

#### UserStorie9

Als Spieler möchte ich die anzahl übrigen Minen sehen, damit ich weiss wie viele ich noch finden muss bis ich gewonnen habe.

##### Akzeptanzkriterien

    1. Das Spiel soll eine Zahl angeben, welche runter geht wenn man eine Flagge setzt.

    2. Die Zahl soll direkt aktualisiert werden beim setzten der Flagge. 

    3. Die Zahl soll wahrheitsgetreu, also der Spielfeld grösse angepasst sein

    4. Das Spiel soll die übrige Anzahl Minen bei einem verlorenem Spiel auch am Ende         anzeigen        

**Tasks**

- [ ] Funktion erstellen die die Anzeige für die Anzahl der gesetzten Flaggen reduziert

---

#### UserStorie10

Als Spieler möchte ich die Möglichkeit haben das Spiel zurückzusetzten, damit falls ich nicht weiter komme, das ich einen Neustart machen kann.

##### Akzeptanzkriterien

    1. Die Tastenangabe dafür soll sich im Menü befinden.

    2. Der Spieler soll beliebige Male das Spiel neustarten können.

    3. Jedes mal beim Neustart soll das Spielfeld neu generiert werden, damit die Minen         nicht an den gleichen Orten sind.

    4. Beim Neustarten soll es die Möglichkeit geben, wieder die         Grösse/Schwierigkeitsstufe anzupassen.

**Tasks**

- [ ] Restart button implementieren die das Spiel zurücksetzt

- [ ] Zurücksetzung des Feldes implementieren

- [ ] Anzahl der Mienen auf höchstanzahl sezten (je nach Spielgrösse unterschiedlich)

- [ ] Funktion aufrufen für die Auswahl der Spielgrösse

---
