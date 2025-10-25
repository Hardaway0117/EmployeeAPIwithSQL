# EmployeeAPIwithSQL

使用 ASP.NET Core 與 Entity Framework Core 建立的 RESTful API 練習專案。  
本專案以 SQLite 為資料庫，實作完整的 CRUD 功能（Create / Read / Update / Delete）。
(Id = PK)
---

透過 API 將前端請求轉換為資料庫操作，  
最終以 JSON 格式回傳結果。

系統以 **Entity Framework Core (EF Core)** 作為 ORM，  
負責在程式與資料庫之間自動轉換。

## 技術

- **ASP.NET Core Web API**
- **Entity Framework Core (ORM)**
- **SQLite 資料庫**
- **Swagger UI** — 方便進行 API 測試
- **Dependency Injection** — 以 `_context` 當pipe注入資料庫物件
- **Model + DbContext 架構分層**

---
## environment

- Visual Studio 2022  
- .NET 8.0  
- C#  
- SQLite  
## text

Run with brwoser > swagger UI (CRUD)
