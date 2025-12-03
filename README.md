# 🦷 Dentist Clinic Management System  
**Windows Forms (.NET Framework) Application for managing a dentist clinic workflow**

---

## 📸 Screenshots  
<img width="746" height="509" alt="image" src="https://github.com/user-attachments/assets/70128211-6c90-4547-a746-49e242bef802" />


### Employee Management Module  
<img width="1752" height="717" alt="image" src="https://github.com/user-attachments/assets/0e38ffe4-088b-4e3d-a37d-741d46465d69" />


---

## 📖 About the Project  
**Dentist Clinic Management System** — це настільний застосунок, створений на базі **C# Windows Forms** та **SQL Server**, який дозволяє автоматизувати процес роботи стоматологічної клініки.

Програма включає модулі для управління:

- 👨‍⚕️ **Працівниками (Employee)**  
- 🦷 **Послугами (Favor / Services)**  
- 📅 **Записами на прийом (Appointment)**  
- 🧾 **Деталями прийому (Appointment Details)**  
- 🧍 **Пацієнтами (Patient)**  
- 🧑‍🔧 **Посадами персоналу (Position)**  
- 💰 **Вартістю послуг (Patient Service Cost)**  
- 📊 **Звіти (MSSQL + ReportViewer)**

---

## ✨ Features  
### 🔹 Employee Module
- Додавання нового працівника  
- Редагування даних  
- Видалення  
- Перегортання записів (First / Last / Next / Previous)  
- Прив’язка до посади  
- Автоматичне збереження в SQL Server  

### 🔹 Patient Module
- Управління персональними даними  
- Перегляд інформації  
- Зміна та збереження  

### 🔹 Appointment Module
- Створення запису  
- Зміна, видалення  
- Прив’язка до пацієнта та працівника  

### 🔹 Favor (Services)
- Список стоматологічних процедур  
- Додати / Змінити / Видалити  

### 🔹 Reporting
- Генерація звітів через **ReportViewer**  
- SQL-запити до бази  

---

## 🛠️ Technologies Used  
- **C# (.NET Framework)**  
- **Windows Forms**  
- **SQL Server (MSSQL)**  
- **ADO.NET**  
- **TableAdapters та DataSets**  
- **Microsoft ReportViewer**  

---

## 🗄️ Database Structure  

Таблиці включають:

- `employee`
- `patient`
- `favor`
- `appointment`
- `appointmentDetails`
- `position`
- `patientServicesCost`

---

## 🚀 How to Run  
1. Clone the repository
git clone https://github.com/yourusername/DentistApp.git

2. Import the SQL Database

У репозиторії є файл SQL зі структурою та даними:
/Database/dentistdb.sql

Щоб імпортувати базу:

Відкрий SQL Server Management Studio (SSMS)
Підключись до свого серверу
Натисни File → Open → File…
Обери файл dentistdb.sql
Натисни Execute (F5)

💡 Це автоматично створить базу DentistDB з усіма таблицями та початковими даними.

3. Update your connection string
У файлі App.config вкажи свій SQL Server:
<connectionStrings>
  <add name="DentistDBConnectionString"
       connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=DentistDB;Integrated Security=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>

Заміни YOUR_SERVER_NAME на назву твого SQL Server, напр.:

4. Run the Project
Відкрий .sln файлик → Запусти на Start (F5).
