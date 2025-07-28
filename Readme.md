# 📋 Vəzifə Verme Proqramı / Task Assignment Program

Sadə **C# konsol tətbiqi** olan bu proqram istifadəçiyə vəzifə siyahısını idarə etməyə imkan verir.  
This is a simple **C# console application** that allows users to manage a task list.

---

## 🔧 Xüsusiyyətlər / Features

- ✅ Siyahıya baxmaq / View the list  
- ✅ Siyahıya yeni vəzifə əlavə etmək / Add new task to the list  
- ✅ Siyahıdan vəzifə silmək / Remove task from the list  
- ✅ Proqramı bağlamaq / Exit the program

---

## 📁 Fayl Strukturu / File Structure

- `data.txt` → Vəzifələrin saxlandığı fayl (hər sətrdə: `Ad Soyad Vəzifə`)  
- `data.txt` → File storing tasks (each line: `FirstName LastName Task`)

---

## 📌 İstifadə Qaydası / Usage

1. Proqram başladıqda mövcud `data.txt` faylından siyahını oxuyur.  
2. Konsoldakı menyudan aşağıdakı seçimlərdən istifadə edə bilərsiniz:  
   - 1: Siyahıya baxmaq  
   - 2: Yeni vəzifə əlavə etmək  
   - 3: Siyahıdan vəzifə silmək  
   - 4: Proqramı bağlamaq  
3. Vəzifə əlavə edərkən ad, soyad və vəzifə məlumatlarını daxil edin.  
4. Vəzifə silmək üçün siyahıdakı ID-ni girin.

1. On start, program reads the existing task list from `data.txt`.  
2. Use the console menu options:  
   - 1: View the list  
   - 2: Add new task  
   - 3: Delete a task  
   - 4: Exit the program  
3. When adding, enter first name, last name, and task.  
4. To delete, enter the ID number from the displayed list.

---

## ⚠️ Qeyd / Notes

- Fayl mövcud deyilsə, vəzifə əlavə etməzdən əvvəl fayl yaradılmalıdır.  
- ID siyahıda göstərilən sıra nömrəsidir.  
- Daxil edilən məlumatlar `data.txt` faylına yazılır.

- If the file doesn't exist, it will be created when adding tasks.  
- ID corresponds to the line number in the list.  
- Entered data is saved to `data.txt`.

---

## 👨‍💻 Müəllif / Author

**Ad:** Əli
**Dil:** C#  
**Tətbiq Tipi:** Konsol tətbiqi  

**Name:** Ali 
**Language:** C#  
**Application Type:** Console app  
