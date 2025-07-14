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
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */