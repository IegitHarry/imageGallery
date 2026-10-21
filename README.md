# 🖼️ Galeria Zdjęć – WPF

Prosta aplikacja desktopowa w C# (WPF) będąca galerią trzech zdjęć. Możesz przełączać zdjęcia strzałkami w lewo i w prawo oraz „polubić” aktualnie wyświetlane zdjęcie. Każde zdjęcie ma własny, niezależny licznik polubień.

## ✨ Funkcje

- Wyświetlanie jednego z trzech zdjęć naraz
- Nawigacja przyciskami `<` i `>` z **zapętleniem** (po ostatnim zdjęciu wracasz do pierwszego i odwrotnie)
- Przycisk **Polub** zwiększający licznik polubień bieżącego zdjęcia
- Osobny licznik dla każdego zdjęcia, wyświetlany na półprzezroczystym pasku u dołu obrazu
- Licznik aktualizuje się automatycznie przy zmianie zdjęcia

## 🧰 Wymagania

- Windows
- Visual Studio z obsługą pulpitu .NET (WPF)
- Trzy pliki graficzne w folderze `images`

## 📁 Struktura projektu

```
WpfApp1/
├── MainWindow.xaml        # interfejs użytkownika
├── MainWindow.xaml.cs     # logika aplikacji
└── images/
    ├── one.png
    ├── two.png
    └── three.png
```

## 🚀 Uruchomienie

1. Otwórz rozwiązanie w Visual Studio.
2. Upewnij się, że w projekcie jest folder `images` z plikami `one.png`, `two.png` i `three.png`.
3. Dla każdego obrazu ustaw w oknie właściwości **Build Action** na `Resource` (lub `Content` wraz z kopiowaniem do katalogu wyjściowego).
4. Uruchom aplikację klawiszem `F5`.

Aby użyć własnych zdjęć, podmień pliki w folderze `images` albo zmień ścieżki w atrybutach `Source` w pliku `MainWindow.xaml`.

## ⚙️ Jak to działa

### Interfejs (`MainWindow.xaml`)

Trzy kontrolki `Image` (`img1`, `img2`, `img3`) leżą w tym samym miejscu okna. Widoczna jest zawsze tylko jedna z nich, pozostałe mają `Visibility="Hidden"`. Pozostałe elementy to:

| Element | Nazwa / zdarzenie | Zadanie |
|---|---|---|
| Przycisk `Polub` | `likeClick` | Dodaje polubienie bieżącemu zdjęciu |
| Przycisk `<` | `leftNextClick` | Poprzednie zdjęcie |
| Przycisk `>` | `rightNextClick` | Następne zdjęcie |
| Pole `likesStrip` | `TextBox` | Pasek z licznikiem polubień |

### Logika (`MainWindow.xaml.cs`)

Stan aplikacji to cztery zmienne:

```csharp
int imageId = 1;      // numer aktualnie wyświetlanego zdjęcia
int img1likes = 0;    // polubienia zdjęcia 1
int img2likes = 0;    // polubienia zdjęcia 2
int img3likes = 0;    // polubienia zdjęcia 3
```

- `likeClick` zwiększa licznik zdjęcia wskazanego przez `imageId` i odświeża tekst paska.
- `leftNextClick` zmniejsza `imageId` (z 1 przeskakuje na 3), a następnie pokazuje odpowiednie zdjęcie i jego licznik.
- `rightNextClick` zwiększa `imageId` (z 3 przeskakuje na 1) i robi to samo.

Fragment zapętlenia nawigacji:

```csharp
imageId++;
if (imageId > 3)
{
    imageId = 1;
}
```

## ⚠️ Uwagi

- **Polubienia nie są zapisywane.** Liczniki istnieją tylko w pamięci, więc po zamknięciu aplikacji wracają do zera.
- Pole `likesStrip` jest zwykłym `TextBox`em, więc użytkownik może kliknąć w nie i edytować tekst. Ustawienie `IsReadOnly="True"` (lub zamiana na `TextBlock`) wyeliminuje ten problem.
- Metoda `likesCounter` (obsługa `TextChanged`) jest pusta i można ją usunąć razem z atrybutem w XAML.
- Interfejs jest częściowo po polsku („Galeria Zdjęć”, „Polub”), a pasek licznika po angielsku („Likes:”).

## 💡 Pomysły na rozwój

- Zapis polubień do pliku (np. JSON) lub ustawień aplikacji
- Zastąpienie trzech zmiennych i trzech `switch`-y tablicą lub listą, co usunie powtórzony kod i ułatwi dodawanie kolejnych zdjęć
- Jedna kontrolka `Image` ze zmienianym `Source` zamiast trzech przełączanych
- Ładowanie zdjęć z wybranego folderu na dysku
- Obsługa klawiszy strzałek na klawiaturze
- Możliwość cofnięcia polubienia

## 📄 Licencja

Projekt udostępniony na licencji MIT. Możesz go dowolnie używać, modyfikować i rozwijać.
