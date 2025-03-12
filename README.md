

# APLICAȚIA FLAPPY BIRD

## Cuprins

1. **Introducere**  
   1.1 Contextul proiectului  
   1.2 Obiective  
   1.3 Specificații și detalii principale  
2. **Descrierea aplicației**  
3. **Implementarea aplicației**  
4. **Testarea aplicației**  
5. **Anexa 1 (Cod sursă)**  

---

## 1. INTRODUCERE

### 1.1 Contextul proiectului  
Acest proiect are ca scop dezvoltarea unei aplicații bazate pe jocul clasic **Flappy Bird**. Jocul a fost ales datorită popularității sale și a mecanicii simple, dar captivante. Într-o lume în care jocurile mobile au devenit parte din viața de zi cu zi, acest proiect oferă oportunitatea de a explora elementele fundamentale ale dezvoltării de jocuri, cum ar fi fizica jocului, coliziunile și mecanica de control a personajului.  

Alegerea **Windows Forms** pentru dezvoltare a fost făcută datorită compatibilității sale cu **C#**, limbaj utilizat pentru construirea aplicațiilor desktop interactive. De asemenea, Windows Forms oferă un mediu eficient pentru crearea interfețelor grafice intuitive și gestionarea evenimentelor.

Prin acest proiect, ne propunem să creăm o versiune simplă, dar funcțională a Flappy Bird, păstrând mecanica originală a jocului și adăugând elemente personalizate pentru o experiență îmbunătățită.

### 1.2 Obiective  
Scopul principal al acestui proiect este implementarea unei aplicații Flappy Bird pentru **platforma Windows**, utilizând **C#** și **Windows Forms**. Printre obiectivele principale ale proiectului se numără:

- **Recrearea mecanicii clasice** a jocului Flappy Bird, inclusiv gravitația și săriturile păsării.  
- **Implementarea unui sistem de coliziuni** între pasăre și obstacole, folosind detecția coliziunilor.  
- **Crearea unei interfețe intuitive** și atractive, care să asigure o experiență fluentă pentru utilizator.  
- **Asigurarea unei rulări fluide** și optimizarea resurselor pentru performanță optimă.  
- **Testarea și validarea aplicației**, pentru a garanta funcționarea corectă și eliminarea eventualelor bug-uri.  

### 1.3 Specificații și detalii principale  

1. **Limbajul de programare**: Aplicația a fost dezvoltată utilizând **C#**, un limbaj robust și potrivit pentru aplicații desktop.  

2. **Tehnologii utilizate**:  
   - **Framework**: Windows Forms – folosit pentru interfața grafică.  
   - **Sistem de gestionare a evenimentelor**: Windows Forms Events.  
   - **Biblioteci suplimentare**: utilizate pentru procesarea coliziunilor și gestionarea animațiilor.  

3. **Funcționalitățile aplicației**:  
   - **Mecanica de săritură** a păsării: utilizatorul controlează pasărea prin apăsarea unui buton.  
   - **Obstacole dinamice**: țevi generate aleatoriu pentru a crea un joc provocator.  
   - **Sistem de coliziuni**: detectarea interacțiunii dintre pasăre și obstacole.  
   - **Scor dinamic**: creșterea scorului pe măsură ce utilizatorul depășește obstacolele.  
   - **Ecran de game over**: notificarea utilizatorului atunci când pierde jocul.  
   - **Restart rapid**: utilizatorul poate relua jocul după un game over fără a închide aplicația.  

4. **Cerințe de sistem**:  
   - Sistem de Operare: **Windows 10 sau mai recent**  
   - Procesor: **Intel Core i3 sau echivalent**  
   - RAM: **minim 1 GB**  
   - Spațiu pe disc: **minim 100 MB**  
   - Rezoluție minimă ecran: **1280x720 pixeli**  

---

## 2. DESCRIEREA APLICAȚIEI  
Aplicația este un **joc single-player**, în care utilizatorul controlează o pasăre care trebuie să evite obstacole și să parcurgă o distanță cât mai mare. Mecanica jocului este simplă: pasărea cade datorită gravitației, iar utilizatorul trebuie să apese un buton pentru a o face să sară.  

Designul este inspirat din jocul original **Flappy Bird**, având un fundal dinamic și țevi generate procedural. Scorul este afișat în timp real și crește cu fiecare obstacol trecut.  

---

## 3. IMPLEMENTAREA APLICAȚIEI  
Implementarea a fost realizată în **C# și Windows Forms**, structura fiind organizată în mai multe componente:  

- **Clasa principală a jocului**, care gestionează logica de joc și evenimentele de utilizator.  
- **Clasa pentru pasăre**, care controlează mișcarea și fizica personajului.  
- **Clasa pentru obstacole**, responsabilă de generarea țevilor și mișcarea acestora.  
- **Sistem de coliziuni**, care detectează interacțiunea dintre pasăre și obstacole.  
- **Gestionarea scorului**, care actualizează și afișează punctajul utilizatorului.  

---

## 4. TESTAREA APLICAȚIEI  
Pentru a asigura stabilitatea și corectitudinea aplicației, am realizat mai multe tipuri de teste:  

- **Teste unitare** pentru verificarea mecanicii de săritură și coliziuni.  
- **Teste de integrare** pentru verificarea interacțiunii dintre componente.  
- **Teste funcționale** pentru a garanta experiența utilizatorului.  
- **Teste de performanță** pentru optimizarea jocului și reducerea întârzierilor.  

Testele au fost realizate pe mai multe configurații hardware pentru a verifica compatibilitatea aplicației.

---

## 5. ANEXA 1 (COD SURSA)  
Codul sursă al proiectului este organizat pe module și poate fi găsit în directorul proiectului. Acesta include fișierele principale necesare pentru rularea și dezvoltarea aplicației.  
