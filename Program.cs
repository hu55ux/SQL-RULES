/*
                                        SQL
 
 
 SQL nədir? 
 SQL (Structured Query Language) verilənlər bazası ilə işləmək üçün istifadə olunan standart bir dildir.
 SQL, verilənləri sorğulamaq, əlavə etmək, yeniləmək və silmək üçün istifadə olunur.
 SQL Declarative Language (Deklarativ Dil) olaraq da bilinir, çünki istifadəçilər verilənlər bazası ilə nə etmək istədiklərini bildirirlər,
 SQL, müxtəlif verilənlər bazası sistemləri tərəfindən dəstəklənir və bu sistemlər arasında müəyyən fərqliliklər olsa da, 
 əsas sintaksis və əməliyyatlar əksər hallarda oxşardır.

 

 MSSQL - Microsoft tərəfindən hazırlanmış və geniş istifadə olunan bir verilənlər bazası idarəetmə sistemidir.  
            T-SQL (Transact-SQL) isə Microsoft SQL Server üçün xüsusi olaraq hazırlanmış bir SQL genişləndirməsidir. 

 DDL (Data Definition Language) - Verilənlər bazası obyektlərinin yaradılması, dəyişdirilməsi və silinməsi üçün istifadə olunan SQL əmrlərini əhatə edir.
            CREATE, ALTER, DROP kimi əmrlər DDL əmrlərinə aiddir.
 
 DML (Data Manipulation Language) - Verilənlər bazasında məlumatların əlavə edilməsi, yenilənməsi və silinməsi üçün istifadə olunan SQL əmrlərini əhatə edir.
            SELECT, INSERT, UPDATE, DELETE kimi əmrlər DML əmrlərinə aiddir.
 
 DCL (Data Control Language) - Verilənlər bazası istifadəçilərinin və onların icazələrinin idarə edilməsi üçün istifadə olunan SQL əmrlərini əhatə edir.
            GRANT, REVOKE , DENY kimi əmrlər DCL əmrlərinə aiddir.
 
 
 SELECT - Verilənlər bazasından məlumatları sorğulamaq üçün istifadə olunan SQL əmri.
            SELECT əmri ilə verilənlər bazasından məlumatları seçə, şərtlərə görə süzgəcləyə və sıralaya bilərsiniz.

SELECT - Əmri ilə biz hər hansı bir columnlarıda seçə bilərik və ya bunların bir yerdə olmasınıda təmin edə bilərik.
            Məsələn, SELECT * FROM TableName; əmri ilə bütün sütunları seçə bilərsiniz.
            Və ya SELECT Column1, Column2 FROM TableName; əmri ilə yalnız müəyyən sütunları seçə bilərsiniz.
 
 FROM - Verilənlər bazasından məlumatları seçmək üçün istifadə olunan SQL əmri.
            FROM əmri ilə hansı cədvəldən məlumatların seçiləcəyini müəyyən edirsiniz.
 
 WHERE - Verilənlər bazasından məlumatları şərtlərə görə süzgəcləmək üçün istifadə olunan SQL əmri.
            WHERE əmri ilə müəyyən şərtlərə uyğun olan məlumatları seçə bilərsiniz.
 
 AS ( təxəllüs, ləqəb ) - SQL-də sütunlara və ya cədvəllərə yeni ad vermək üçün istifadə olunan açar sözdür.
            AS əmri ilə sütun və ya cədvəl adlarını daha oxunaqlı və anlaşılan etmək üçün istifadə edə bilərsiniz.
 
 Əgər columnların adlarından hər hansı biri SQL açar sözləri ilə eynidirsə, 
            bu zaman həmin halların qarşısını almaq üçün [] istifadə edə bilərsiniz.

DISTINCT - Verilənlər bazasından unikal (təkrarlanmayan) məlumatları seçmək üçün istifadə olunan SQL əmri.
            DISTINCT əmri ilə təkrarlanan məlumatları aradan qaldıraraq yalnız unikal məlumatları əldə edə bilərsiniz.
 
 ORDER BY - Verilənlər bazasından seçilmiş məlumatları müəyyən bir sütuna görə sıralamaq üçün istifadə olunan SQL əmri.
            ORDER BY əmri ilə məlumatları artan (ASC) və ya azalan (DESC) sıraya görə sıralaya bilərsiniz.
 
 Operatorlar - = (bərabər), != (bərabər deyil), > (böyük), < (kiçik), >= (böyük və ya bərabər), <= (kiçik və ya bərabər) kimi operatorlar SQL-də şərtləri müəyyən etmək üçün istifadə olunur.
            Bu operatorlar WHERE əmri ilə birlikdə istifadə edilərək məlumatların süzgəclənməsini təmin edir.
 
 
 Operatorlarla işləyən zaman əgər nvarchar dataları yoxlayırıqsa qarşısına N əlavə edirik.
            Məsələn, WHERE ColumnName = N'Value' kimi.

AND - SQL-də iki və ya daha çox şərti birləşdirmək üçün istifadə olunan operator.
            AND operatoru ilə bir neçə şərti eyni anda yoxlaya bilərsiniz. 
            Məsələn, WHERE Column1 = 'Value1' AND Column2 = 'Value2' kimi.

OR - SQL-də iki və ya daha çox şərti birləşdirmək üçün istifadə olunan operator.
            OR operatoru ilə bir neçə şərtdən ən az birinin doğru olduğu halları seçə bilərsiniz.
            Məsələn, WHERE Column1 = 'Value1' OR Column2 = 'Value2' kimi.

NOT - SQL-də bir şərtin əksini yoxlamaq üçün istifadə olunan operator.
            NOT operatoru ilə müəyyən bir şərtin doğru olmadığı halları seçə bilərsiniz.
            Məsələn, WHERE NOT ColumnName = 'Value' kimi.

Biz hər hansı bir columnun null olub olmamasını yoxlamaq üçün
            IS NULL və ya IS NOT NULL istifadə edirik.
            Məsələn, WHERE ColumnName IS NULL və ya WHERE ColumnName IS NOT NULL kimi.
 
 IN - SQL-də bir sütunun müəyyən bir dəyər siyahısında olub olmadığını yoxlamaq üçün istifadə olunan operator.
            IN operatoru ilə bir sütunun dəyərinin müəyyən bir siyahıda olub olmadığını yoxlaya bilərsiniz.
            Məsələn, WHERE ColumnName IN ('Value1', 'Value2', 'Value3') kimi.

BETWEEN - SQL-də bir sütunun müəyyən bir aralıqda olub olmadığını yoxlamaq üçün istifadə olunan operator.
            BETWEEN operatoru ilə bir sütunun dəyərinin müəyyən bir aralıqda olub olmadığını yoxlaya bilərsiniz.
            Məsələn, WHERE ColumnName BETWEEN 'Value1' AND 'Value2' kimi.

LIKE - SQL-də bir sütunun müəyyən bir nümunəyə uyğun olub olmadığını yoxlamaq üçün istifadə olunan operator.
           LIKE operatoru ilə bir sütunun dəyərinin müəyyən bir nümunəyə uyğun olub olmadığını yoxlaya bilərsiniz.
            Məsələn, WHERE ColumnName LIKE 'Value%' kimi. Bu nümunədə % simvolu hər hansı bir ardıcıllığı təmsil edir.
            LIKE operatoru ilə həmçinin _ simvolunu da istifadə edə bilərsiniz, bu simvol isə yalnız bir xarakteri təmsil edir.
            Məsələn, WHERE ColumnName LIKE 'Val_e' kimi. Bu nümunədə Val və e arasında yalnız bir xarakter ola bilər.

TOP(n) - SQL-də verilənlər bazasından yalnız müəyyən sayda sətiri seçmək üçün istifadə olunan əmrdır.
            TOP əmri ilə sorğunun nəticələrindən yalnız ilk n sətiri əldə edə bilərsiniz.
            Məsələn, SELECT TOP(10) * FROM TableName; əmri ilə cədvəldən yalnız ilk 10 sətiri seçə bilərsiniz.
            TOP əmri yalnız MSSQL-də mövcuddur. Digər verilənlər bazası sistemlərində LIMIT və ya ROWNUM kimi fərqli sintaksislər istifadə olunur.

 
 OFFSET - SQL-də verilənlər bazasından seçilmiş məlumatların başlanğıc nöqtəsini təyin etmək üçün istifadə olunan əmrdır.
            OFFSET əmri ilə sorğunun nəticələrindən yalnız müəyyən bir başlanğıc nöqtəsindən başlayaraq sətirləri seçə bilərsiniz.
            Məsələn, SELECT * FROM TableName ORDER BY ColumnName OFFSET 10 ROWS; əmri ilə cədvəldən 10-cu sətirdən başlayaraq bütün sətirləri seçə bilərsiniz.
            OFFSET əmri yalnız MSSQL-də mövcuddur. Digər verilənlər bazası sistemlərində LIMIT və ya ROWNUM kimi fərqli sintaksislər istifadə olunur.
 
FETCH NEXT - SQL-də verilənlər bazasından seçilmiş məlumatların növbəti hissəsini təyin etmək üçün istifadə olunan əmrdır.
            FETCH NEXT əmri ilə sorğunun nəticələrindən yalnız müəyyən bir sayda sətiri seçə bilərsiniz.
            Məsələn, SELECT * FROM TableName ORDER BY ColumnName OFFSET 10 ROWS FETCH NEXT 5 ROWS ONLY; əmri ilə cədvəldən 10-cu sətirdən başlayaraq növbəti 5 sətiri seçə bilərsiniz.
            FETCH NEXT əmri yalnız MSSQL-də mövcuddur. Digər verilənlər bazası sistemlərində LIMIT və ya ROWNUM kimi fərqli sintaksislər istifadə olunur.
 


                                                                    AGGREGATE FUNCTIONS
 
 
 SUM - SQL-də bir sütunun dəyərlərinin cəmini hesablamaq üçün istifadə olunan funksiyadır.
            SUM funksiyası ilə müəyyən bir sütunun bütün dəyərlərini toplayaraq cəmi əldə edə bilərsiniz.
            Məsələn, SELECT SUM(ColumnName) FROM TableName; əmri ilə cədvəldəki ColumnName sütununun bütün dəyərlərinin cəmini əldə edə bilərsiniz.
 
 
 COUNT - SQL-də bir sütunun dəyərlərinin sayını hesablamaq üçün istifadə olunan funksiyadır.
            COUNT funksiyası ilə müəyyən bir sütundakı qeydlərin sayını əldə edə bilərsiniz.
            Məsələn, SELECT COUNT(ColumnName) FROM TableName; əmri ilə cədvəldəki ColumnName sütunundakı qeydlərin sayını əldə edə bilərsiniz.

AVG - SQL-də bir sütunun dəyərlərinin ortalamasını hesablamaq üçün istifadə olunan funksiyadır.
            AVG funksiyası ilə müəyyən bir sütunun bütün dəyərlərinin ortalamasını əldə edə bilərsiniz.
            Məsələn, SELECT AVG(ColumnName) FROM TableName; əmri ilə cədvəldəki ColumnName sütununun bütün dəyərlərinin ortalamasını əldə edə bilərsiniz.

MIN - SQL-də bir sütunun dəyərlərinin minimumunu hesablamaq üçün istifadə olunan funksiyadır.
            MIN funksiyası ilə müəyyən bir sütunun ən kiçik dəyərini əldə edə bilərsiniz.
            Məsələn, SELECT MIN(ColumnName) FROM TableName; əmri ilə cədvəldəki ColumnName sütununun ən kiçik dəyərini əldə edə bilərsiniz.

MAX - SQL-də bir sütunun dəyərlərinin maksimumunu hesablamaq üçün istifadə olunan funksiyadır.
            MAX funksiyası ilə müəyyən bir sütunun ən böyük dəyərini əldə edə bilərsiniz.
            Məsələn, SELECT MAX(ColumnName) FROM TableName; əmri ilə cədvəldəki ColumnName sütununun ən böyük dəyərini əldə edə bilərsiniz.
 
 
 GROUP BY - SQL-də verilənlər bazasındakı məlumatları müəyyən bir sütuna görə qruplaşdırmaq üçün istifadə olunan əmrdır.
            GROUP BY əmri ilə müəyyən bir sütunun dəyərlərinə görə məlumatları qruplaşdıra bilərsiniz.
            Məsələn, SELECT ColumnName, COUNT(*) FROM TableName GROUP BY ColumnName; əmri ilə cədvəldəki ColumnName sütununa görə məlumatları qruplaşdıraraq hər qrupun sayını əldə edə bilərsiniz.
 
 HAVING - SQL-də GROUP BY əmri ilə qruplaşdırılmış məlumatlara şərt əlavə etmək üçün istifadə olunan əmrdır.
            HAVING əmri ilə qruplaşdırılmış məlumatların müəyyən bir şərtə uyğun olanlarını seçə bilərsiniz.
            Məsələn, SELECT ColumnName, COUNT(*) FROM TableName GROUP BY ColumnName HAVING COUNT(*) > 1; əmri ilə cədvəldəki ColumnName sütununa görə qruplaşdırılmış məlumatlardan yalnız sayısı 1-dən böyük olanları əldə edə bilərsiniz.
 
 Aggregate funksiyalara parametr olaraq digər aggregate funksiyaları göndərmək olmaz.
 
 

Sorğuların sintaktik ardıcıllığı:

1. SELECT - Hər şeydən əvvəl, hansı sütunları və ya funksiyaları seçmək istədiyinizi müəyyən edirsiniz.
2. FROM - Hansı cədvəldən məlumatları seçəcəyinizi göstərirsiniz.
3. WHERE - Seçilmiş məlumatları şərtlərə görə süzgəcləyirsiniz.
4. GROUP BY - Məlumatları müəyyən bir sütuna görə qruplaşdırırsınız.
5. HAVING - Qruplaşdırılmış məlumatlara şərt əlavə edirsiniz.
6. ORDER BY - Seçilmiş və ya qruplaşdırılmış məlumatları müəyyən bir sütuna görə sıralayırsınız.

Sorğuların işləmə ardıcıllığı:

1. FROM - Əvvəlcə, məlumatların hansı cədvəldən alınacağını müəyyən edirsiniz.
2. WHERE - Sonra, şərtlərə uyğun olan məlumatları süzgəcləyirsiniz.
3. GROUP BY - Məlumatları müəyyən bir sütuna görə qruplaşdırırsınız.    
4. HAVING - Qruplaşdırılmış məlumatlara şərt əlavə edirsiniz.
5. SELECT - Seçilmiş və ya qruplaşdırılmış məlumatları göstərirsiniz.
6. ORDER BY - Nəticələri müəyyən bir sütuna görə sıralayırsınız.



INSERT - SQL-də verilənlər bazasına yeni məlumat əlavə etmək üçün istifadə olunan əmrdır.
            INSERT əmri ilə cədvələ yeni sətirlər əlavə edə bilərsiniz.
            Məsələn, INSERT INTO TableName (Column1, Column2) VALUES ('Value1', 'Value2'); əmri ilə TableName cədvəlinə yeni bir sətir əlavə edə bilərsiniz.

Multivalues insert
            INSERT INTO TableName (Column1, Column2) VALUES ('Value1', 'Value2'), ('Value3', 'Value4'), ('Value5', 'Value6'); əmri ilə TableName cədvəlinə birdən çox sətir əlavə edə bilərsiniz.
 
 Bu prosess zamanı qarşımıza bir problem çıxa bilər . Bu problem əgər primary key və ya unique constraint varsa, 
            həmin constraint-lərə uyğun olmayan məlumat əlavə etməyə çalışdıqda meydana çıxır.
            Bu zaman biz SET IDENTITY_INSERT TableName ON; əmri ilə həmin cədvəl üçün identity insert-i aktivləşdirə bilərik.
            Bu əmrdən sonra biz INSERT INTO TableName (Column1, Column2) VALUES (1, 'Value1'); kimi əmrlərlə cədvələ yeni sətirlər əlavə edə bilərik.
            Lakin bu əmrdən sonra SET IDENTITY_INSERT TableName OFF; əmri ilə identity insert-i deaktiv etməyi unutmayın.

UPDATE - SQL-də verilənlər bazasında mövcud məlumatları yeniləmək üçün istifadə olunan əmrdır.
            UPDATE əmri ilə cədvəldəki mövcud sətirləri yeniləyə bilərsiniz.
            Məsələn, UPDATE TableName SET Column1 = 'NewValue' WHERE Column2 = 'OldValue'; əmri ilə TableName cədvəlində Column2 sütunu 'OldValue' olan sətirlərin Column1 sütununu 'NewValue' ilə yeniləyə bilərsiniz.
 
 
 
                                                                                    ZAMAN İLƏ İŞLƏYƏN FUNKSİYALAR
 
 İndiki vaxtı almaq üçün - SELECT SYSDATETIME(); və ya SELECT GETDATE(); əmrlərini istifadə edə bilərsiniz.
            Bu əmrlər verilənlər bazasında indiki tarix və saatı göstərir.
 
 İli almaq üçün - SELECT YEAR(SYSDATETIME()); və ya SELECT YEAR(GETDATE()); əmrlərini istifadə edə bilərsiniz.
            Bu əmrlər verilənlər bazasında indiki ilin 4 rəqəmli formatını göstərir.

  Ayı almaq üçün - SELECT MONTH(SYSDATETIME()); və ya SELECT MONTH(GETDATE()); əmrlərini istifadə edə bilərsiniz.

Günün gününü almaq üçün - SELECT DAY(SYSDATETIME()); və ya SELECT DAY(GETDATE()); əmrlərini istifadə edə bilərsiniz.
            Bu əmrlər verilənlər bazasında indiki ayın gününü göstərir.
 
DATEDIFF - SQL-də iki tarix arasındakı fərqi hesablamaq üçün istifadə olunan funksiyadır.
            DATEDIFF funksiyası ilə iki tarix arasındakı gün, ay və ya il fərqini əldə edə bilərsiniz.
            Məsələn, SELECT DATEDIFF(DAY, '2023-01-01', '2023-12-31'); əmri ilə 2023-cü ilin yanvar ayının 1-dən dekabr ayının 31-nə qədər olan gün fərqini əldə edə bilərsiniz.
 





                                                                            Anomaliyalar və onlara qarşı mübarizə üsulları
 
 İlk olaraq normal table nə olduğunu deyək.
Normal table - Verilənlər bazasında məlumatların saxlanılması üçün istifadə olunan standart cədvəldir.
            Normal table-də məlumatlar sütunlar və sətirlər şəklində təşkil edilir.
            Hər sütun müəyyən bir məlumat tipini təmsil edir və hər sətir isə bir qeydi təmsil edir.
Normal table-də sadəcə bir Entity olmalıdır.
            Yəni, hər sütun yalnız bir məlumat tipini təmsil etməlidir və hər sətir yalnız bir qeydi təmsil etməlidir.
            Bu, məlumatların düzgün və effektiv şəkildə saxlanılmasını təmin edir.

Anomaliyalar - Verilənlər bazasında məlumatların saxlanılması və işlənməsi zamanı meydana çıxan problemlərdir.
Database-də 3 əsas anomaliya növü mövcuddur:
1. İnsert Anomaliyası - Yeni məlumat əlavə edərkən, digər məlumatların da daxil edilməsi və ya yenilənməsi tələb olunur.
            Məsələn, əgər bir cədvəldə müştəri və sifariş məlumatları birlikdə saxlanılırsa, yeni müştəri əlavə edərkən sifariş məlumatlarını da daxil etmək lazım ola bilər.
            Bu, məlumatların təkrarlanmasına və saxlanılmasına səbəb ola bilər.
 
2. Update Anomaliyası - Mövcud məlumatları yeniləyərkən, digər məlumatların da dəyişdirilməsi və ya yenilənməsi tələb olunur.
            Məsələn, əgər bir cədvəldə müştəri və sifariş məlumatları birlikdə saxlanılırsa, müştərinin adını dəyişdirmək istədikdə, bütün müştəri qeydlərini yeniləmək lazım ola bilər.
            Bu, məlumatların təkrarlanmasına və saxlanılmasına səbəb ola bilər.

3. Delete Anomaliyası - Mövcud məlumatları silərkən, digər məlumatların da silinməsi və ya itirilməsi tələb olunur.
            Məsələn, əgər bir cədvəldə müştəri və sifariş məlumatları birlikdə saxlanılırsa, bir müştərini silmək istədikdə, onunla əlaqəli bütün sifariş məlumatlarını da silmək lazım ola bilər.
            Bu, məlumatların itirilməsinə və ya təkrarlanmasına səbəb ola bilər.



Normallaşdırılmamış databaselərin əlamətləri:
1. Məlumatların təkrarlanması - Eyni məlumat bir neçə dəfə saxlanılır, bu da məlumatların təkrarlanmasına və saxlanılmasına səbəb olur.

Normallaşdırılmış databaselərin əlamətləri:
1. Məlumatlar təkrarlanmamalıdır.
2. Hər sütun yalnız bir məlumat tipini təmsil etməlidir. Yəni hər sütun yalnız bir Entity olmalıdır.



Normalladırmanın 3 əsas forması var:
1. Birinci Normal Forma (1NF) - 1NF ehtiva edir ki tables-da təkrarlanan sütun və sətirlər olmamalıdır 
və sütun və sətirlərin kəsişməsində olan informasiya atomar (bölünməz) olmalıdır.
Atomar informasiya - Məlumatın daha kiçik və bölünməz hissələrə ayrılmasıdır.
            Məsələn, bir cədvəldə "Ad və Soyad" sütunu varsa, bu sütunu "Ad" və "Soyad" olaraq iki ayrı sütuna bölmək 1NF-ə uyğun olacaq.
 
2. İkinci Normal Forma (2NF) - 2NF ehtiva edir ki tables-da 1NF artıq tətbiq olunur. 
 Və açar olmayan sütunlar İlkin açardan (Primary Key) asılı olmalıdır.
 Bu da o deməkdir ki hər bir table yalnız və yalnız bir Entity-ni təmsil etməlidir.
 Yəni, hər sütun yalnız bir açar sütununa (Primary Key) bağlı olmalıdır.
 Məsələn, əgər bir cədvəldə "Müştəri ID", "Müştəri Adı" və "Sifariş Tarixi" sütunları varsa, "Müştəri Adı" sütunu yalnız "Müştəri ID" sütununa bağlı olmalıdır.
 
 
3. Üçüncü Normal Forma (3NF)  - 3NF ehtiva edir ki tables-da artıq 1NF və 2NF artıq tətbiq olunur.
Və açar olmayan sütunlar yalnız və yalnız İlkin Açardan (Primary Key) asılı olmalıdır.
Məsələn əgər bir mağazada total qiymət var isə, bu qiymət yalnız və yalnız məhsulun qiymətindən asılı olmalıdır.
Əgər bizim bu asılılıqlar bizə üstünlük yaradırsa bu zaman 3NF məcburi deyil. Amma 1NF və 2NF məcburidir.






                                                                            Data types in SQL

Exact numeric types - Tam ədədləri təmsil edən məlumat tipləridir.
            Məsələn, INT, BIGINT, SMALLINT, TINYINT kimi.

int- 4 baytlıq tam ədəd tipidir. -2,147,483,648-dən 2,147,483,647-ə qədər olan dəyərləri təmsil edə bilər.
bigint - 8 baytlıq tam ədəd tipidir. -9,223,372,036,854,775,808-dən 9,223,372,036,854,775,807-ə qədər olan dəyərləri təmsil edə bilər.
smallint - 2 baytlıq tam ədəd tipidir. -32,768-dən 32,767-ə qədər olan dəyərləri təmsil edə bilər.
tinyint - 1 baytlıq tam ədəd tipidir. 0-dan 255-ə qədər olan dəyərləri təmsil edə bilər.
bit - 1 bitlik məntiqi dəyər tipidir. 0 və ya 1 dəyərlərini təmsil edə bilər.
decimal - Sabit nöqtəli ədədləri təmsil edən məlumat tipidir. 
            Məsələn, DECIMAL(10, 2) tipində bir sütun 10 rəqəmli tam ədəd və 2 rəqəmli onluq hissəni təmsil edə bilər.
            Bu tipdəki sütunlar dəqiq hesablamalar üçün istifadə olunur.
money - Pul dəyərlərini təmsil edən məlumat tipidir. 
            Məsələn, MONEY tipində bir sütun 922,337,203,685,477.5807 qədər pul dəyərini təmsil edə bilər.
            Bu tipdəki sütunlar maliyyə hesablamaları üçün istifadə olunur.
smallmoney - Daha kiçik pul dəyərlərini təmsil edən məlumat tipidir. 
            Məsələn, SMALLMONEY tipində bir sütun 214,748.3647 qədər pul dəyərini təmsil edə bilər.
            Bu tipdəki sütunlar maliyyə hesablamaları üçün istifadə olunur.


Approximate numeric types - Yaxınlaşma ilə təmsil olunan ədədləri təmsil edən məlumat tipləridir.
            Məsələn, FLOAT və REAL kimi.
float - Yaxınlaşma ilə təmsil olunan ədədləri təmsil edən məlumat tipidir.
            FLOAT tipindəki sütunlar 1.79E+308 qədər böyük və -1.79E+308 qədər kiçik dəyərləri təmsil edə bilər.
            Bu tipdəki sütunlar elmi hesablamalar üçün istifadə olunur.
real - FLOAT tipinin daha kiçik versiyasıdır.
            REAL tipindəki sütunlar 3.40E+38 qədər böyük və -3.40E+38 qədər kiçik dəyərləri təmsil edə bilər.
            Bu tipdəki sütunlar elmi hesablamalar üçün istifadə olunur.

Date and time types - Tarix və vaxtı təmsil edən məlumat tipləridir.
            Məsələn, DATE, TIME, DATETIME, DATETIME2, SMALLDATETIME kimi.

date - Tarixi təmsil edən məlumat tipidir.
            DATE tipindəki sütunlar 0001-01-01-dən 9999-12-31-ə qədər olan tarixləri təmsil edə bilər.
time - Vaxtı təmsil edən məlumat tipidir.
            TIME tipindəki sütunlar 00:00:00-dən 23:59:59.9999999-a qədər olan vaxtları təmsil edə bilər.
datetime - Tarix və vaxtı təmsil edən məlumat tipidir.
            DATETIME tipindəki sütunlar 1753-01-01-dən 9999-12-31-ə qədər olan tarix və vaxtları təmsil edə bilər.
datetime2 - DATETIME tipinin daha dəqiq versiyasıdır.
            DATETIME2 tipindəki sütunlar 0001-01-01-dən 9999-12-31-ə qədər olan tarix və vaxtları təmsil edə bilər.
            Bu tipdəki sütunlar daha dəqiq tarix və vaxt məlumatları üçün istifadə olunur.
smalldatetime - DATETIME tipinin daha kiçik versiyasıdır.
            SMALLDATETIME tipindəki sütunlar 1900-01-01-dən 2079-06-06-ya qədər olan tarix və vaxtları təmsil edə bilər.
            Bu tipdəki sütunlar daha kiçik tarix və vaxt məlumatları üçün istifadə olunur.
datetime offset - Tarix və vaxtı təmsil edən məlumat tipidir.
            DATETIMEOFFSET tipindəki sütunlar 0001-01-01-dən 9999-12-31-ə qədər olan tarix və vaxtları təmsil edə bilər.
            Bu tipdəki sütunlar zaman zonası məlumatlarını da saxlayır.

character types - Simvolları təmsil edən məlumat tipləridir.
            Ascii character types - ASCII simvollarını təmsil edən məlumat tipləridir.
            Məsələn, CHAR, VARCHAR, NCHAR, NVARCHAR kimi.
char - Sabit uzunluqlu simvolları təmsil edən məlumat tipidir.
            CHAR tipindəki sütunlar 1-dən 8000-ə qədər simvolu təmsil edə bilər.
            Bu tipdəki sütunlar sabit uzunluqlu simvollar üçün istifadə olunur.

varchar - Dəyişən uzunluqlu simvolları təmsil edən məlumat tipidir.
            VARCHAR tipindəki sütunlar 1-dən 8000-ə qədər simvolu təmsil edə bilər.
            Bu tipdəki sütunlar dəyişən uzunluqlu simvollar üçün istifadə olunur.
text - Çox uzun simvolları təmsil edən məlumat tipidir.
            TEXT tipindəki sütunlar 2^31-1 simvola qədər olan mətnləri təmsil edə bilər.
            Bu tipdəki sütunlar çox uzun mətn məlumatları üçün istifadə olunur.

Unicode character types - Unicode simvollarını təmsil edən məlumat tipləridir.
            Unicode simvolları, müxtəlif dillərdəki simvolları təmsil etmək üçün istifadə olunur.
            Məsələn, NCHAR, NVARCHAR, NTEXT kimi.
nchar - Sabit uzunluqlu Unicode simvollarını təmsil edən məlumat tipidir.
            NCHAR tipindəki sütunlar 1-dən 4000-ə qədər Unicode simvolunu təmsil edə bilər.
            Bu tipdəki sütunlar sabit uzunluqlu Unicode simvollar üçün istifadə olunur.
nvarchar - Dəyişən uzunluqlu Unicode simvollarını təmsil edən məlumat tipidir.
            NVARCHAR tipindəki sütunlar 1-dən 4000-ə qədər Unicode simvolunu təmsil edə bilər.
            Bu tipdəki sütunlar dəyişən uzunluqlu Unicode simvollar üçün istifadə olunur.
ntext - Çox uzun Unicode simvollarını təmsil edən məlumat tipidir.
            NTEXT tipindəki sütunlar 2^30-1 Unicode simvoluna qədər olan mətnləri təmsil edə bilər.
            Bu tipdəki sütunlar çox uzun Unicode mətn məlumatları üçün istifadə olunur.


 char və nchar fixed sized amma varchar və nvarchar variable sized-dir.
            Yəni, char və nchar sütunları sabit uzunluqlu simvolları təmsil edir, 
            lakin varchar və nvarchar sütunları dəyişən uzunluqlu simvolları təmsil edir.
            Bu səbəbdən, varchar və nvarchar sütunları daha az yer tutar və daha çevikdir.
 
 
binary types - İkili məlumatları təmsil edən məlumat tipləridir.
            Məsələn, BINARY, VARBINARY, IMAGE kimi.
binary - Sabit uzunluqlu ikili məlumatları təmsil edən məlumat tipidir.
            BINARY tipindəki sütunlar 1-dən 8000-ə qədər baytı təmsil edə bilər.
            Bu tipdəki sütunlar sabit uzunluqlu ikili məlumatlar üçün istifadə olunur.

varbinary - Dəyişən uzunluqlu ikili məlumatları təmsil edən məlumat tipidir.
            VARBINARY tipindəki sütunlar 1-dən 8000-ə qədər baytı təmsil edə bilər.
            Bu tipdəki sütunlar dəyişən uzunluqlu ikili məlumatlar üçün istifadə olunur.
image - Çox uzun ikili məlumatları təmsil edən məlumat tipidir.
            IMAGE tipindəki sütunlar 2^31-1 bayta qədər olan ikili məlumatları təmsil edə bilər.
            Bu tipdəki sütunlar çox uzun ikili məlumatlar üçün istifadə olunur.


other data types - Digər məlumat tipləridir.
            Məsələn, XML, JSON, HIERARCHYID, GEOGRAPHY, GEOMETRY kimi.
xml - XML məlumatlarını təmsil edən məlumat tipidir.
            XML tipindəki sütunlar XML formatında məlumatları təmsil edə bilər.
            Bu tipdəki sütunlar XML məlumatları üçün istifadə olunur.
json - JSON məlumatlarını təmsil edən məlumat tipidir.
            JSON tipindəki sütunlar JSON formatında məlumatları təmsil edə bilər.
            Bu tipdəki sütunlar JSON məlumatları üçün istifadə olunur.
hierarchyid - Hiyerarşik məlumatları təmsil edən məlumat tipidir.
            HIERARCHYID tipindəki sütunlar hiyerarşik məlumatları təmsil edə bilər.
            Bu tipdəki sütunlar hiyerarşik məlumatlar üçün istifadə olunur.
geography - Coğrafi məlumatları təmsil edən məlumat tipidir.
            GEOGRAPHY tipindəki sütunlar coğrafi məlumatları təmsil edə bilər.
            Bu tipdəki sütunlar coğrafi məlumatlar üçün istifadə olunur.
geometry - Coğrafi məlumatları təmsil edən məlumat tipidir.
            GEOMETRY tipindəki sütunlar coğrafi məlumatları təmsil edə bilər.
            Bu tipdəki sütunlar coğrafi məlumatlar üçün istifadə olunur.
 




                                                                            Constraints in SQL

Constraints - məhdudiyyətlərdir.
            Constraints, verilənlər bazasında məlumatların düzgünlüyünü və bütövlüyünü təmin etmək üçün istifadə olunur.
            Məsələn, PRIMARY KEY, FOREIGN KEY, UNIQUE, CHECK kimi məhdudiyyətlər.

Primary Key - Cədvəldəki hər bir sətiri unikal şəkildə təmsil edən sütundur.
            PRIMARY KEY məhdudiyyəti ilə təyin olunan sütun və ya sütunlar cədvəldəki hər bir sətiri unikal şəkildə təmsil edir.
            Bu, məlumatların təkrarlanmasının qarşısını alır və verilənlər bazasında məlumatların düzgünlüyünü təmin edir.
            Hər cədvəldə yalnız bir PRIMARY KEY ola bilər.
İdentity - SQL Server-də PRIMARY KEY sütununa avtomatik olaraq unikal dəyərlər təyin etmək üçün istifadə olunan bir xüsusiyyətdir.
            IDENTITY sütunu, yeni sətirlər əlavə edildikdə avtomatik olaraq artan bir ədəd təyin edir.
            Məsələn, IDENTITY(1,1) ilə təyin olunan bir sütun, ilk sətir üçün 1, ikinci sətir üçün 2 və s. dəyərləri alacaq.
Default - SQL Server-də sütunlara avtomatik olaraq dəyər təyin etmək üçün istifadə olunan bir xüsusiyyətdir.
            DEFAULT məhdudiyyəti ilə təyin olunan sütun, yeni sətirlər əlavə edildikdə avtomatik olaraq müəyyən bir dəyər alır.
            Məsələn, DEFAULT GETDATE() ilə təyin olunan bir sütun, yeni sətirlər əlavə edildikdə avtomatik olaraq indiki tarix və saatı alacaq.
Check - SQL Server-də sütunlara müəyyən şərtlərə uyğun dəyərlər təyin etmək üçün istifadə olunan bir məhdudiyyətdir.
            CHECK məhdudiyyəti ilə təyin olunan sütun, yalnız müəyyən şərtlərə uyğun dəyərləri qəbul edir.
            Məsələn, CHECK (ColumnName > 0) ilə təyin olunan bir sütun, yalnız 0-dan böyük dəyərləri qəbul edəcək.
Unique - SQL Server-də sütunların unikal dəyərlərini təmin etmək üçün istifadə olunan bir məhdudiyyətdir.
            UNIQUE məhdudiyyəti ilə təyin olunan sütun, cədvəldəki hər bir sətir üçün unikal dəyərləri təmin edir.
            Bu, məlumatların təkrarlanmasının qarşısını alır və verilənlər bazasında məlumatların düzgünlüyünü təmin edir.
Null or Not Null - SQL Server-də sütunların NULL və ya NOT NULL olmasını təyin etmək üçün istifadə olunan bir məhdudiyyətdir.
            NULL məhdudiyyəti ilə təyin olunan sütun, dəyəri olmayan və ya məlum olmayan məlumatları qəbul edir.
            NOT NULL məhdudiyyəti ilə təyin olunan sütun, dəyəri olan və məlum olan məlumatları qəbul edir.
            Bu, verilənlər bazasında məlumatların düzgünlüyünü və bütövlüyünü təmin edir.
Foreign Key - Cədvəldəki sütunların digər cədvəllərlə əlaqələrini təyin etmək üçün istifadə olunan bir məhdudiyyətdir.
           FOREIGN KEY məhdudiyyəti ilə təyin olunan sütun, digər cədvəldəki PRIMARY KEY və ya UNIQUE sütununa istinad edir.
            Bu, verilənlər bazasında məlumatların bütövlüyünü və əlaqələrini təmin edir.
            FOREIGN KEY məhdudiyyəti ilə təyin olunan sütun, yalnız digər cədvəldəki uyğun dəyərləri qəbul edir.
            Bu, məlumatların təkrarlanmasının qarşısını alır və verilənlər bazasında məlumatların düzgünlüyünü təmin edir.


Bu Constraintslərin hər birinin özünə uyğun bir prefiksi var:
PK - Primary Key
FK - Foreign Key
CK - Check
UQ - Unique
DF - Default

GO keyword - SQL Server-də əmrləri icra etmək üçün istifadə olunan bir açar sözdür.
            GO açar sözü, SQL Server-ə əmrlərin sonunu bildirir və əmrləri icra etməyə başlayır.
            Bu, SQL Server-ə bir neçə əmri eyni anda icra etməyə imkan verir.
            Məsələn, bir neçə CREATE TABLE əmri yazdıqdan sonra GO açar sözünü istifadə edərək bütün əmrləri eyni anda icra edə bilərsiniz.



-- SQL-in əsas anlayışları və əmrləri haqqında məlumat
ON DELETE - silinmə zamanı baş verəcək 4 hadisə var :
1. ON DELETE NO ACTION - Əgər silinən sətirə istinad edən digər cədvəllərdə sətirlər varsa, silmə əməliyyatı icra olunmayacaq.
2. ON DELETE CASCADE - Əgər silinən sətirə istinad edən digər cədvəllərdə sətirlər varsa, həmin sətirlər də avtomatik olaraq silinəcək.
3. ON DELETE SET NULL - Əgər silinən sətirə istinad edən digər cədvəllərdə sətirlər varsa, həmin sətirlərin FOREIGN KEY sütunları NULL dəyərinə təyin ediləcək.
4. ON DELETE SET DEFAULT - Əgər silinən sətirə istinad edən digər cədvəllərdə sətirlər varsa, həmin sətirlərin FOREIGN KEY sütunları DEFAULT dəyərinə təyin ediləcək.

ON UPDATE - yenilənmə zamanı baş verəcək 4 hadisə var:
1. ON UPDATE NO ACTION - Əgər yenilənən sətirə istinad edən digər cədvəllərdə sətirlər varsa, yeniləmə əməliyyatı icra olunmayacaq.
2. ON UPDATE CASCADE - Əgər yenilənən sətirə istinad edən digər cədvəllərdə sətirlər varsa, həmin sətirlər də avtomatik olaraq yenilənəcək.
3. ON UPDATE SET NULL - Əgər yenilənən sətirə istinad edən digər cədvəllərdə sətirlər varsa, həmin sətirlərin FOREIGN KEY sütunları NULL dəyərinə təyin ediləcək.
4. ON UPDATE SET DEFAULT - Əgər yenilənən sətirə istinad edən digər cədvəllərdə sətirlər varsa, həmin sətirlərin FOREIGN KEY sütunları DEFAULT dəyərinə təyin ediləcək.


1-1 və ya 1-çox əlaqəsi zamanı ən az 2 table istifadə olunmalıdır. 
Amma çox-çox əlaqəsi zamanı minimum 3 table istifadə olunmalıdır.
            Bu, çox-çox əlaqələrinin düzgün işləməsi üçün tələb olunur.
            Çox-çox əlaqələrdə, iki cədvəl arasında bir vasitəçi cədvəl (junction table) istifadə olunur.
            Bu vasitəçi cədvəl, hər iki cədvəldəki sütunların istinadlarını saxlayır və əlaqələri təmsil edir.


Table yarandıqdan sonra biz bu table-a data və ya constraint əlavə etmək istəyə bilərik. Bu zaman biz ALTER TABLE əmrlərindən istifadə edirik.
            ALTER TABLE əmri ilə cədvəldəki sütunları əlavə edə, silə və ya dəyişdirə bilərsiniz.
            Məsələn, ALTER TABLE TableName ADD ColumnName DataType; əmri ilə TableName cədvəlinə yeni bir sütun əlavə edə bilərsiniz.
            Və ya ALTER TABLE TableName DROP COLUMN ColumnName; əmri ilə TableName cədvəlindən bir sütunu silə bilərsiniz.
            Həmçinin, ALTER TABLE TableName ALTER COLUMN ColumnName DataType; əmri ilə TableName cədvəlindəki bir sütunun məlumat tipini dəyişdirə bilərsiniz.
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */