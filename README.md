# 📨 ApiPublisher

Este projeto é uma **API REST em ASP.NET Core** responsável por publicar mensagens de pedidos em uma fila RabbitMQ, onde outro serviço (consumer) consome essas mensagens e salva os dados no banco de dados SQL Server.

---

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core
- RabbitMQ
- Entity Framework Core
- SQL Server
- Docker (RabbitMQ)
- C#
- postman

---

## 📦 Funcionalidade

A API expõe um endpoint `POST` para envio de pedidos no formato JSON.
