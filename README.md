### ความเป็นมาของโปรแกรม
โปรมแกรมที่สร้างขึ้นมาคือ การจำลองจองตั๋วไปสำรวจดาวเคราห์อื่น เพราะว่า สร้างขึ้นมาจากความฝันที่จำลองถึงการผจญภัยในอวกาศ ล่องลอยเหนือเมฆ ท่ามกลางหมู่ดาว ระหว่างดวงดาวต่างๆ

<br/><br/>
### วัตถุประสงค์ของโปรแกรม
เพื่อกระตุ้นความคิดสร้างสรรค์และสร้างแรงบันดาลใจให้ผู้คนใฝ่ฝันถึงการสำรวจอวกาศ

<br/><br/>
### โครงสร้างของโปรแกรม (Class diagram)
```mermaid
classDiagram
    Program <|-- HyperLightSpeedDrive
    HyperLightSpeedDrive <|-- Planet
    HyperLightSpeedDrive <|-- Spaceship
    HyperLightSpeedDrive <|-- CalPrice
    Program : +Main()
    class HyperLightSpeedDrive{
        +FileToolStripMenuItem_Click()
        +OpenToolStripMenuItem_Click()
        +SaveToolStripMenuItem_Click()
        +CalPricebutton_Click()
        +Savebutton_Click()
        +Cancelbutton_Click()
    }
    class Planet{
        -Matar_Bay : string 
        - Alathfar_XI : string 
        - Charon_Prime : string 
        - Asperoth_Prime : string 
        - Bore_Rock : string 
        - Pathfinder_V : string 
        - Klen_Dahth_II : string 
        - Widows_Harbor : string 
        - New_Haven : string 
        - Pilen_V : string 
    }
    class Spaceship{
        -Skywalker_OG : string 
        -Ghost_Trai_Haze; : string 
        -Blue_Dream : string 
        -Candy_Kush_Express : string 
    }
    class CalPrice{
        +CalculateTotalPrice(spaceship: string,planet: string) int
    }
    
```

<br/><br/>
### ชื่อของผู้พัฒนาโปรแกรม
643450789-0 ธนกร ภิรมย์กุล

