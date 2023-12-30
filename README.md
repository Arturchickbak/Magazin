**Бакузов Артур Сергеевич**
===============================
Группа: ИП-20-7К
-------------------------------
Тема: Web Api-Магазин автозапчастей 
-------------------------------
![image](https://github.com/Arturchickbak/Magazin/assets/83332216/1dcbee1a-2a90-4cd7-880b-08aad1a25b29)

-------------------------------
```mermaid
erDiagram
    client ||--o{ Magazin : places
    Pclient {
        string Name
        string Inn
        string Kpp
    }
  
    Magazin {
        int client
        string Name
        string Summa
    }
  Car ||--o{ Magazin: is
    Car {
        string Marka
        string Model
        string Gos_Number
        string ViN
        int Probeg
    }
 Postavshik ||--o{ Magazin: is
  Postavshik {
    string Name
   int Card 
    int Number 
    string Email
   }
```
