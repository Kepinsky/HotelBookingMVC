
# Dokumentacja projektu HotelBookingMVC

## Wymagania wstępne
Przed rozpoczęciem instalacji i konfiguracji projektu upewnij się, że masz zainstalowane następujące narzędzia:

- **Visual Studio 2022** (z włączoną obsługą .NET 7.0 i Entity Framework Core).
- **SQL Server Management Studio (SSMS)** – do zarządzania bazą danych.
- **.NET SDK 7.0** – do uruchamiania i budowania projektu.
- **Git** – do pobrania repozytorium projektu.
- Przeglądarka internetowa (np. Google Chrome, Edge) – do testowania aplikacji.

---

## Instrukcja instalacji

### 1. Klonowanie repozytorium
Pobierz kod projektu z repozytorium GitHub za pomocą następującego polecenia:
```bash
git clone https://github.com/Kepinsky/HotelBookingMVC.git
```

### 2. Otwórz projekt w Visual Studio
1. Uruchom Visual Studio.
2. Wybierz opcję **Open a project or solution** i wskaż plik `HotelBookingMVC.sln` znajdujący się w folderze repozytorium.

### 3. Przywróć pakiety NuGet
W Visual Studio otwórz **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution** i upewnij się, że wszystkie zależności są przywrócone. Alternatywnie, możesz użyć terminala:
```bash
dotnet restore
```

### 4. Konfiguracja połączenia z bazą danych
1. Otwórz plik `appsettings.json` w folderze głównym projektu.
2. Znajdź sekcję `ConnectionStrings` i zaktualizuj ją, wprowadzając swoje dane:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=HotelBookingDb;Trusted_Connection=True;"
}
```
   - **Server**: Wprowadź nazwę swojego serwera SQL (np. `DESKTOP-XXXX\SQLEXPRESS`).
   - **Database**: Upewnij się, że nazwa bazy danych to `HotelBookingDb`.

### 5. Utworzenie i zaktualizowanie bazy danych
1. W terminalu Visual Studio uruchom następujące polecenia, aby zastosować migracje bazy danych:
```bash
dotnet ef database update
```
2. Sprawdź, czy baza danych została utworzona w SQL Server Management Studio (powinna zawierać tabele: `Hotels`, `Rooms`, `Reservations`, `Users`).

---

## Uruchamianie aplikacji

### 1. W Visual Studio
1. Wybierz konfigurację **Debug** lub **Release**.
2. Kliknij **IIS Express** lub naciśnij klawisz `F5`, aby uruchomić aplikację.
3. Aplikacja powinna otworzyć się w domyślnej przeglądarce pod adresem:
   ```
   https://localhost:<port>/
   ```

### 2. Testowanie WebAPI (Swagger)
1. Otwórz adres Swaggera w przeglądarce:
   ```
   https://localhost:<port>/swagger
   ```
2. Sprawdź dostępne endpointy dla API, takie jak:
   - `GET /api/Hotels`
   - `POST /api/Hotels`
   - `PUT /api/Hotels/{id}`
   - `DELETE /api/Hotels/{id}`

3. Przetestuj funkcjonalność, wysyłając zapytania.

---

## Testowanie aplikacji

1. **Funkcjonalności Web**:
   - Dodawanie, edytowanie i usuwanie hoteli, pokojów oraz rezerwacji.
   - Wyświetlanie listy wszystkich rekordów w każdej kategorii.

2. **Funkcjonalności API**:
   - Używając Swaggera lub Postmana, przetestuj CRUD dla wszystkich encji (`Hotels`, `Rooms`, `Reservations`, `Users`).

---

## Struktura projektu

- **Models/** – Modele aplikacji (Hotel, Room, Reservation, User).
- **Controllers/** – Kontrolery MVC oraz API.
- **Data/** – Kontekst bazy danych (ApplicationDbContext).
- **Views/** – Widoki Razor dla każdej encji.
- **wwwroot/** – Zasoby statyczne (CSS, JS).

---

## Dodatkowe uwagi
- Jeśli występują błędy podczas uruchamiania projektu, upewnij się, że:
  - Connection string w `appsettings.json` jest poprawny.
  - Migracje zostały poprawnie zastosowane.
  - Pakiety NuGet są zaktualizowane.

- W przypadku problemów z API, sprawdź działanie endpointów w Swaggerze.

- Projekt nie został w pełni ukończony.

---

## Autor
Projekt zrealizowany przez Kacpra Kępińskiego 15019, w ramach zajęć na uczelni.
