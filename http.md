# HTTP metodları və izahları
## HTTP metodları aşağıdakılardır
- GET
- HEAD
- POST
- PUT
- DELETE
- CONNECT
- OPTİONS
- TRACE

## GET metodu
Bu metod serverdən URL hissəsində bildirilən parametrlərdə verilənləri almaq üçün istifadə olunur. Heç bir şəkildə verilənlərə müdaxilə edə, onları silə, dəyişdirə və ya yaza bilməz. Aşağıda nümunə olaraq GET metodu ilə bağlı HTTP istəyi göstərilmişdir:
```
GET /hello.htm HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
Host: www.tutorialspoint.com
Accept-Language: en-us
Accept-Encoding: gzip, deflate
Connection: Keep-Alive
```
Və bu istəyə cavab nümunəsi:
```
HTTP/1.1 200 OK
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Last-Modified: Wed, 22 Jul 2009 19:15:56 GMT
ETag: "34aa387-d-1568eb00"
Vary: Authorization,Accept
Accept-Ranges: bytes
Content-Length: 88
Content-Type: text/html
Connection: Closed
```
```
<html>
<body>
<h1>Hello, World!</h1>
</body>
</html>
```
## HEAD metodu
Bu metod GET metoduna bənzərdir və onunla demək olar ki, eyni xüsusiyyətləri daşıyır. Aradakı fərq bundan ibarətdir ki, HEAD metodu HTTP cavab mesajının sadəcə başlıq hissəsini ala bilir, bədən hissəsi isə bu istəyə cavab olaraq göndərilmir. Nümunə:
```
HEAD /hello.htm HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
Host: www.tutorialspoint.com
Accept-Language: en-us
Accept-Encoding: gzip, deflate
Connection: Keep-Alive
```
Və bu istəyə cavab nümunəsi:
```
HTTP/1.1 200 OK
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Last-Modified: Wed, 22 Jul 2009 19:15:56 GMT
ETag: "34aa387-d-1568eb00"
Vary: Authorization,Accept
Accept-Ranges: bytes
Content-Length: 88
Content-Type: text/html
Connection: Closed
```
GET və HEAD nümunələrini müqayisə etsəniz HEAD metoduna cavab olaraq mesajın bədən hissəsinin yox, sadəcə başlıq hissəsinin gəldiyini görərsiniz.
## POST metodu
Bu metoddan serverə müəyyən datalar göndərilməsi zamanı istifadə olunur. Əsasən HTML form-ları vasitəsilə istifadəçidən alınan şəxsi məlumatlar, fayl göndərmələri və s. bu metod vasitəsilə serverə, oradan da verilənlər bazasına göndərilir. Nümunə HTTP istək mesajı:
```
POST /cgi-bin/process.cgi HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
Host: www.tutorialspoint.com
Content-Type: text/xml; charset=utf-8
Content-Length: 88
Accept-Language: en-us
Accept-Encoding: gzip, deflate
Connection: Keep-Alive
```
```
<?xml version="1.0" encoding="utf-8"?>
<string xmlns="http://clearforest.com/">string</string>
```
Və HTTP cavab mesajı nümunəsi:
```
HTTP/1.1 200 OK
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Last-Modified: Wed, 22 Jul 2009 19:15:56 GMT
ETag: "34aa387-d-1568eb00"
Vary: Authorization,Accept
Accept-Ranges: bytes
Content-Length: 88
Content-Type: text/html
Connection: Closed
```
```
<html>
<body>
<h1>Request Processed Successfully</h1>
</body>
</html>
```
## PUT metodu
Bu metod istifadəçinin bəlirlənmiş URL-də göndərilən verilənlərin saxlanılması üçün istifadə olunur. Nümunə istək mesajı:
```
PUT /hello.htm HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
Host: www.tutorialspoint.com
Accept-Language: en-us
Connection: Keep-Alive
Content-type: text/html
Content-Length: 182
```
```
<html>
<body>
<h1>Hello, World!</h1>
</body>
</html>
```
Burada istək mesajının bədən hissəsində göndərilmiş HTML verilənlərinin "hello.htm" adresində saxlanılması istəyi göndərilmişdir.
Və uyğun cavab mesajı nümunəsi:
```
HTTP/1.1 201 Created
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Content-type: text/html
Content-length: 30
Connection: Closed
```
```
<html>
<body>
<h1>The file was created.</h1>
</body>
</html>
```
## DELETE metodu
Bu metod istifadəçinin bəlirlənmiş URL-də yerləşən faylı silməsi üçün istifadə olunur. Nümunə istək mesajı:
```
DELETE /hello.htm HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
Host: www.tutorialspoint.com
Accept-Language: en-us
Connection: Keep-Alive
```
Uyğun cavab mesajı nümunəsi:
```
HTTP/1.1 200 OK
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Content-type: text/html
Content-length: 30
Connection: Closed
```
```
<html>
<body>
<h1>URL deleted.</h1>
</body>
</html>
```
## CONNECT metodu
Bu metod istifadəçini serverə HTTP üzərindən qoşulmasını təmin etmək məqsədilə istifadə edilən metoddur. Nümunə istək mesajı:
```
CONNECT www.tutorialspoint.com HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
```
Uyğun cavab mesajı nümunəsi:
```
HTTP/1.1 200 Connection established
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
```
## OPTİONS metodu
Bu metod şəbəkə serverinin dəstəklədiyi metodları göstərmək üçün istifadə olunur. İstifadəçi istək zamanı bəlirli bir URL bildirə və ya * simvolundan istifadə edərək bütün serveri nəzərdə tuta bilər. Nümunə istək mesajı:
```
OPTIONS * HTTP/1.1
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
```
Uyğun cavab mesajı nümunəsi:
```
HTTP/1.1 200 OK
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Allow: GET,HEAD,POST,OPTIONS,TRACE
Content-Type: httpd/unix-directory
```
Göründüyü kimi cavab mesajının "Allow" field-də dəstəklənən HTTP metodları sıralanıb.
## TRACE metodu
Bu metodu proqramçı proqram yazdığı zaman xətaları tapmaq məqsədi ilə istifadə edə bilər. Göndərilmiş HTTP istəyi cavab mesajı olaraq geri (exolanır) döndürülür. Nümunə istək mesajı:
```
TRACE / HTTP/1.1
Host: www.tutorialspoint.com
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
```
Uyğun cavab mesajı nümunəsi:
```
HTTP/1.1 200 OK
Date: Mon, 27 Jul 2009 12:28:53 GMT
Server: Apache/2.2.14 (Win32)
Connection: close
Content-Type: message/http
Content-Length: 39

TRACE / HTTP/1.1
Host: www.tutorialspoint.com
User-Agent: Mozilla/4.0 (compatible; MSIE5.01; Windows NT)
```
Göründüyü kimi cavab mesajının "Allow" field-də dəstəklənən HTTP metodları sıralanıb.



