# 🐱‍👤🍓FruitNinjaWinFormsApp
Копия известной игры **«FruitNinja»**, созданной в процессе изучения технологии Windows Forms, принципов ООП, работы со звуком, асинхронностью и многопоточностью.

<div " align="center">
  
![FruitNinja_Preview](https://github.com/IvanPovaliaev/FruitNinjaWinFormsApp/assets/157638990/29a7e755-fc95-4daf-8cc1-2faffbf4578a)

</div>

## 📝Описание работы
Из-за нижней границы экрана вылетают разные фрукты, которые затем падают под действием силы тяжести. Игроку необходимо движением мышки по шарику порезать шарик, после чего он исчезает.<br />
Помимо обычных фруктов имеются ещё особые:
* **Банан** - при соприкосновении с ним фрукты двигаются и вылетают медленнее на некоторое время в зависимости от текущей сложности игры. Соответственно, ловить их легче. 
* **Бомба** - ари соприкосновении с ним игра завершается досрочно. 

### 📜Привила игры
1. Когда фрукт появляется на экране, игрок должен зажать ЛКМ, чтобы разрубить его пополам.
2. За разрезание 1 фрукта даётся 1 очко.
3. В зависимости от текущего уровня сложности игроку даётся до 3 жизней.
4. При пропуске 1 фрукта теряется 1 жизнь.
5. При потере всех жизней игра заканчивается.

### ⚙️Настройки и сложность

<div " align="center">
  
![image](https://github.com/IvanPovaliaev/FruitNinjaWinFormsApp/assets/157638990/43830379-772b-4c9d-848c-e10ca81f5e7e)

</div>

В настройках имеется возможность регулирования громкости звуков и выбора уровня сложности игры. Всего существует 3 уровня сложности:
1. Лёгкий уровень `Easy`:
    * Количество жизней — 3
    * Продолжительность замедления за 1 банан — 5 сек.
    * Фрукты и бомбы вылетают менее часто.
2. Стандартный уровень `Normal`:
    * Количество жизней — 3
    * Продолжительность замедления за 1 банан — 3 сек.
    * Стандартная частота вылета фруктов и бомб.
3. Сложный уровень `Hard`:
    * Количество жизней — 2
    * Продолжительность замедления за 1 банан: 2 сек.
    * Фрукты и бомбы вылетают более часто.
  
### 🕹️Геймплей:

<div " align="center">

https://github.com/IvanPovaliaev/FruitNinjaWinFormsApp/assets/157638990/6091fd49-1980-49ff-ba6f-e33ac8d1709e

</div>

## 🛠️Техническая часть

Проект выполнен с соблюдением принципов **ООП** и использованием **LINQ**.

Решение содержит 2 проекта:
1. Проект общей библиотеки `BallGame.Common`.
2. Проект `FruitNinjaWinFormsApp`.

### 🏗️Архитектура
Структура каталога решения:<br />
![image](https://github.com/IvanPovaliaev/FruitNinjaWinFormsApp/assets/157638990/82d9a6c9-2055-4835-9271-826120fd083e)

`BallGame.Common` является общей библиотекой классов для следующих проектов:
* [BallGamesWindowsFormApp](https://github.com/IvanPovaliaev/BallGamesWindowsFormApp)
* [FruitNinjaWinFormsApp](https://github.com/IvanPovaliaev/FruitNinjaWinFormsApp)
* [AngryBirdsWinFormsApp](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp)

### 🎶Работа со звуком
Для работы со звуком была использована библиотека `NAudio`. Работа со звуком осуществляется с помощью статического класса `AudioProvider` общей библиотеки `BallGame.Common`:
```csharp
public static class AudioProvider
{
    public async static Task PlaySoundAsync(string audiofilePath, int soundVolume)
    {
        await Task.Run(() =>
        {
            var player = new WaveOutEvent();
            var audioFileReader = new AudioFileReader(audiofilePath);
            player.Init(audioFileReader);
            player.Volume = soundVolume / 100f;

            player.PlaybackStopped += (sender, e) =>
            {
                player.Dispose();
                audioFileReader.Dispose();
            };

            player.Play();
        });
    }
}
```
### ☰ Работка с потоками
Для разгрузки UI-потока логика была вынеса в отдельные потоки.<br />
Например, логика движения (не отрисовки) каждого фрукта была выделена в отдельный поток с помощью таймера `System.Timers.Timer`, инициализированного в родительском абстрактном классе `MoveImageRectangle`.
```csharp
public abstract class MoveImageRectangle : ImageRectangle
{
    protected System.Timers.Timer timer;
    protected float vx = -3;
    protected float vy = 15;

    public MoveImageRectangle(Form form) : base(form)
    {
        InitializeTimer();
    }
    public void Start() => timer.Start();
    public void Stop() => timer.Dispose();
    public void AddDissapearEvent(EventHandler dissapearEvent) => timer.Disposed += dissapearEvent;
    protected virtual void Go()
    {
        centerX += vx;
        centerY += vy;
    }
    protected virtual void Move() => Go();
    protected abstract void Move_Tick(object? sender, EventArgs e);
    private void InitializeTimer()
    {
        timer = new System.Timers.Timer();
        timer.Interval = 10;
        timer.Elapsed += Move_Tick;
    }
```
В классе наследнике `Fruit` реализован метод `Move_Tick`:
```csharp
protected override void Move_Tick(object? sender, EventArgs e)
{
    Move();
    if (FullyOutForm()) Stop();
}    
```

