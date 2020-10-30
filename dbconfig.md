Projeye DByi entegre etmek için.
Article_Api.DataAccess katmanına girip  ArticleApiDbContext.cs kısmından server bilgilerini yazın.
Daha sonra Solition  Explorer penceresinden;
Article_Api.DataAccess katmanınına sağ tıklayıp Set As Startup  Project  olarak ayarlayın,
Nuget Package Consoleyi açın Default Project Kısmından Article_Api_DataAccess seçin.
PM> add-migration İnitialCreate
PM> update-database

Komutlarını  yazın.

Db ve tablolar Sql Serverinize dahil edilmiş olacak.

Daha sonra ArticleApi Katmanına sağ tıklayıp Set As Startup  Project  olarak ayarlayın.

Projeyi çalıştırın. Açılan Api dökümasyonundan parametrelere bakabilirsiniz.

http://domain.com:19783/api/Article/generate
get yaparak  500 adet fake veri üretebilirsiniz.
