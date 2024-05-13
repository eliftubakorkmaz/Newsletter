🚀 Yeni bir web uygulaması geliştirdim! Bu projede .NET çerçevesini kullanarak MVC (Model-View-Controller) mimarisini hayata geçirdim. 🖥️

📧 Uygulama, web sitesine abone olan kullanıcılara her yayınlanan makaleyi otomatik olarak email olarak gönderiyor. Bu süreçte, email şablonları için Fluent Email kütüphanesini kullandım. Fluent Email, gelişmiş email tasarımları ve gönderim kolaylığı sunar.

🔧 Email gönderimlerini test etmek için smtp4dev'i tercih ettim. smtp4dev, geliştirme aşamasında email gönderimlerini lokal bir server üzerinden simüle ederek, gerçek bir mail server'ı kullanmadan test yapma imkanı sağlar.

📬 Ayrıca, sistem içi mesajlaşmayı yönetmek ve asenkron işlemleri koordine etmek için RabbitMQ kullanıyorum. RabbitMQ, uygulama bileşenleri arasında güvenilir ve ölçeklenebilir bir mesajlaşma altyapısı sağlayarak, yüksek erişilebilirlik ve performans sunar. Kullanılan kuyruk yapısı (queue), mesajların düzenli ve verimli bir şekilde işlenmesini sağlar.

🏗️ Projem, beş ana katmandan oluşuyor:
Application: İş kurallarını ve uygulama mantığını yönetir.
Consumer: RabbitMQ üzerinden gelen mesajları işleyen ve kuyruk yapısını kullanan bu katman, asenkron veri işleme sağlar.
Domain: Uygulamanın temel iş mantığını ve nesnelerini içerir.
Infrastructure: Veri erişim katmanı ve diğer dış servislerle entegrasyonları içerir.
MVC: Kullanıcı arayüzü ve sunum katmanını yönetir.
Bu katmanlı mimari sayesinde, projem daha temiz, yönetilebilir ve ölçeklenebilir hale geliyor. 🔍💡
