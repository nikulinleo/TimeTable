using Xamarin.Forms;
using System.Collections.Generic;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;


namespace HelloApp
{
    class StartPage : Shell
    {
        void load()
        {
            DB.Idiots["Даня"] = new Idiot("Даня");
            DB.Idiots["Даня"].AddPair("Математический анализ+10.45+12.10+520 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Математический анализ+12.20+13.45+520 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Физкультура+13.55+15.20+++1+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Введение в программирование+17.05+18.30+УЛК 1 №5.16++1+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Введение в программирование+18.35+20.00+УЛК 1 №5.16++1+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Математическая логика+10.45+12.10+428 ГК++2+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Структуры данных+12.20+13.45+702 КПМ++2+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Структуры данных+13.55+15.20+702 КПМ++2+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Иностранный язык+15.30+16.55+++2+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Аналитическая геометрия+10.45+12.10+Онлайн+Подлипский О.К.+3+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Математическая логика+12.20+13.45+Онлайн+Дашков Е.В.+3+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Математический анализ+13.55+15.20+Онлайн+Редкозубов В.В+3+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Математический анализ+9.00+10.25+Онлайн++4+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Программирование и алгоритмы+13.55+15.20+Онлайн++4+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Структуры данных+17.05+18.30+++4+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("История+18.35+20.00+Онлайн++4+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Физкультура+10.45+12.10+++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Аналитическая геометрия+12.20+13.45+420 ГК++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Иностранный язык+13.55+15.20+++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Введение в структуры данных+17.05+18.30+УЛК 2 №425++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Введение в структуры данных+18.35+20.00+УЛК 2 №425++5+0,1,2,3+Семинар");

            DB.Idiots["Паша"] = new Idiot("Паша");
            DB.Idiots["Паша"].AddPair("Физкультура+9.0+10.25+++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Математический анализ+10.45+12.10+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Математический анализ+12.20+13.45+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Иностранный язык+13.55+15.20+315 НК++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Математический анализ+10.45+12.10+Онлайн+Редкозубова Е.Ю.+2+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Аналитическая геометрия+12.20+13.45+Онлайн+Ершов А.В.+2+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Биология клетки+13.55+15.20+Онлайн+Носов Г.А.+2+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Биологическая практика+10.45+12.10+217 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Паша"].AddPair("Физкультура+13.55+15.20+++3+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Общая и неорганическая химия+15.30+16.55+409 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Аналитическая геометрия+17.5+18.30+411 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Биология клетки+10.45+12.10+516а ГК++4+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Иностранный язык+15.30+16.55+315 НК++4+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Практикум по химии+17.5+18.30+210 БК++4+0,1,2,3+Лабораторная работа");
            DB.Idiots["Паша"].AddPair("Практикум по химии+18.35+20.0+210 БК++4+0,1,2,3+Лабораторная работа");
            DB.Idiots["Паша"].AddPair("Математический анализ+9.0+10.25+Онлайн+Редкозубова Е.Ю.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Общая биология+10.45+12.10+Онлайн+Скобеева В.А.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Основы химии+13.55+15.20+Онлайн+Инденбом А.В.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("История+15.30+16.55+Онлайн+Суриков И.Е.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Программирование на Python+9.0+10.25+705 КПМ++6+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Программирование на Python+10.45+12.10+705 КПМ++6+0,1,2,3+Семинар");

            DB.Idiots["Ксюша"] = new Idiot("Ксюша");
            DB.Idiots["Ксюша"].AddPair("Физкультура+9.00+10.25+++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Математический анализ+10.45+12.10+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Математический анализ+12.20+13.45+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Иностранный язык+13.55+15.20+325 НК++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Математический анализ+10.45+12.10+Онлайн+Редкозубова Е.Ю.+2+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Аналитическая геометрия+12.20+13.45+Онлайн+Ершов А.В.+2+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Биология клетки+13.55+15.20+Онлайн+Носов Г.А.+2+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Биологическая практика+9.00+10.25+217 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Ксюша"].AddPair("Общая и неорганическая химия+12.20+13.45+210 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Практикум по химии+13.55+15.20+211 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Ксюша"].AddPair("Практикум по химии+15.30+16.55+211 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Ксюша"].AddPair("Аналитическая геометрия+17.05+18.30+210 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Физкультура+10.45+12.10+++4+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Биология клетки+12.20+13.45+426 ГК++4+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Иностранный язык+13.55+15.20+325 НК++4+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Математический анализ+9.00+10.25+Онлайн+Редкозубова Е.Ю.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Общая биология+10.45+12.10+Онлайн+Скобеева В.А.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Основы химии+13.55+15.20+Онлайн+Инденбом А.В.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("История+15.30+16.55+Онлайн+Суриков И.Е.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Программирование на Python+9.00+10.25+702 КПМ++6+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Программирование на Python+10.45+12.10+702 КПМ++6+0,1,2,3+Семинар");

            DB.Idiots["Лев"] = new Idiot("Лев");
            DB.Idiots["Лев"].AddPair("Программирование+15.40+17.15+845+Станислав+1+0,2+лаб");
            DB.Idiots["Лев"].AddPair("Программирование+17.25+19.00+845+Станислав+1+0,2+лаб");
            DB.Idiots["Лев"].AddPair("Социология+10.15+11.50+615Л+Казакова А. А.+2+0,1,2,3+сем");
            DB.Idiots["Лев"].AddPair("Английский язык+12.00+13.35+630Л++2+0,1,2,3+сем");
            DB.Idiots["Лев"].AddPair("Математический анализ+13.50+15.25+218Л+Подзорова М. И.+2+0,1,2,3+лек");
            DB.Idiots["Лев"].AddPair("Начертательная геометрия+15.40+17.15+218Л+Ерёменко Л. Н.+2+0,1,2,3+лек");
            DB.Idiots["Лев"].AddPair("Физкультура+12.00+13.35+СК+Сасин А. А.+3+0,1,2,3+сем");
            DB.Idiots["Лев"].AddPair("Программирование+15.40+17.15+501Ю+Иванова Г. С.+3+0,1,2,3+лек");
            DB.Idiots["Лев"].AddPair("Информатика+17.25+19.00+501Ю+Губарь А. М.+3+0,1,2,3+лек");
            DB.Idiots["Лев"].AddPair("Программирование+12.00+13.35+218Л+Иванова Г. С.+4+1,3+лек");
            DB.Idiots["Лев"].AddPair("Информатика+13.50+15.25+218Л+Губарь А. М.+4+1,3+лек");
            DB.Idiots["Лев"].AddPair("Начертательная геометрия+10.15+11.50+1136Л+Мугла Д. Р.+5+0,1,2,3+сем");
            DB.Idiots["Лев"].AddPair("Программирование+12.00+13.35+529Л+Минитаева А. М.+5+0,1,2,3+сем");
            DB.Idiots["Лев"].AddPair("Математический анализ+13.50+15.25+1015Л+Птицына И. В.+5+1,3+сем");
            DB.Idiots["Лев"].AddPair("Информатика+13.50+15.25+534Л+Бауман Ю. И.+5+0,2+сем");
            DB.Idiots["Лев"].AddPair("Математический анализ+15.40+17.15+1015Л+Птицына И. В.+5+0,1,2,3+сем");
            DB.Idiots["Лев"].AddPair("Аналитическая геометрия+8.30+10.05+830Л+Птицына И. В.+6+0,1,2,3+сем");
            DB.Idiots["Лев"].AddPair("Аналитическая геометрия+10.15+11.50+224Л+Птицына И. В.+6+0,1,2,3+лек");
            DB.Idiots["Лев"].AddPair("Социология+12.00+13.35+224Л+Семина М. В.+6+0,2+лек");
            DB.Idiots["Лев"].AddPair("Физкультура+13.50+15.25+СК++6+0,1,2,3+сем");

            DB.Idiots["Аня"] = new Idiot("Аня");
            DB.Idiots["Аня"].AddPair("Алгебра и геометрия+10.30+12.05+zoom+Тыртышников Е.Е.+1+0,1,2,3+лекция");
            DB.Idiots["Аня"].AddPair("Алгоритмы+8.45+10.20+zoom+Белеванцев А.А.+1+0,1,2,3+лекция");
            DB.Idiots["Аня"].AddPair("Математический анализ+12.50+14.25+zoom+Садовничая И.В.+1+0,1,2,3+лекция");
            DB.Idiots["Аня"].AddPair("История+14.35+16.10+zoom+Чубыкин И.В.+1+0,2+лекция ");
            DB.Idiots["Аня"].AddPair("Физкультура+14.35+16.10+zoom++1+1,3+лекция");
            DB.Idiots["Аня"].AddPair("БЖД+16.20+17.55+G classroom++1+0,1,2,3+лекция");
            DB.Idiots["Аня"].AddPair("Английский язык +8.45+10.20+549+Шабловский А.А.+2+0,1,2,3+семинар");
            DB.Idiots["Аня"].AddPair("Алгебра и геометрия+10.30+12.05+503+Востриков И.В.+2+0,1,2,3+семинар");
            DB.Idiots["Аня"].AddPair("Математический анализ+12.50+14.25+605+Хорошилова Е.В.+2+0,1,2,3+семинар");
            DB.Idiots["Аня"].AddPair("Практикум на ЭВМ+14.35+16.10+682+Манушин Д.В.+2+0,1,2,3+семинар");
            DB.Idiots["Аня"].AddPair("Алгоритмы+8.45+10.20+zoom+Белеванцев А.А.+3+0,1,2,3+лекция");
            DB.Idiots["Аня"].AddPair("Алгебра и геометрия+10.30+12.05+zoom+Тыртышников Е.Е.+3+0,1,2,3+лекция");
            DB.Idiots["Аня"].AddPair("Математический анализ+12.50+14.25+zoom+Садовничая И.В.+3+0,1,2,3+лекция");
            DB.Idiots["Аня"].AddPair("Физкультура+8.45+10.20+малый газон+Святослав Олегович+4+0,1,2,3+семинар ");
            DB.Idiots["Аня"].AddPair("Алгебра и геометрия+10.30+12.05+504+Востриков И.В.+4+0,1,2,3+семинар ");
            DB.Idiots["Аня"].AddPair("Английский язык+12.50+14.25+782+Шабловский А.А.+4+0,1,2,3+семинар ");
            DB.Idiots["Аня"].AddPair("Практикум на ЭВМ+14.35+16.10+248+Манушин Д.В.+4+0,1,2,3+семинар ");
            DB.Idiots["Аня"].AddPair("История+10.30+12.05+526-б+Чубыкин И.В.+5+0,1,2,3+семинар");
            DB.Idiots["Аня"].AddPair("Математический анализ+12.50+14.25+707+Хорошилова Е.В.+5+0,1,2,3+семинар");
        }
        public StartPage()
        {
            load(); 

            Items.Add(new FlyoutItem
            {
                Title = "All Idiots",
                Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new UnifiedWeekPage()}}
                    }
                }
            });

            foreach (string item in DB.Idiots.Keys)
            {
                Items.Add(new FlyoutItem
                {
                    Title = DB.Idiots[item].Name,
                    Items =
                {
                    new Tab
                    {
                        Items = { new ShellContent {Content = new PersonalPage(DB.Idiots[item])} }
                    }
                }
                });
            }
            CurrentItem = Items[2];
        }
    }
    class PersonalPage : TabbedPage
    {
        public PersonalPage(Idiot idiot)
        {
            int CurrentWeek = (DateTime.Today.Subtract(new DateTime(2020, 8, 31, 0, 0, 0)).Days / 7) % 4;
            for (int i = 0; i < 4; i++)
            {
                PersonalWeekPage weekpage = new PersonalWeekPage(idiot.STDWeeks[i]) { Title = (i+1).ToString() };
                Children.Add(weekpage);
            }
            CurrentPage = Children[CurrentWeek];
        }
    }
    class PersonalWeekPage : TabbedPage
    {
        public PersonalWeekPage(STDWeek week)
        {
            int CurrentWeekDay = DateTime.Today.Subtract(new DateTime(2020, 8, 31, 0, 0, 0)).Days % 7;
            string[] days = new string[6];
            days[0] = "пн";
            days[1] = "вт";
            days[2] = "ср";
            days[3] = "чт";
            days[4] = "пт";
            days[5] = "сб";
            for (int i = 0; i < 6; i++)
            {
                PersonalDayPage day = new PersonalDayPage(week.Days[i]) { Title = days[i] };
                Children.Add(day);
            }
            if (CurrentWeekDay == 6) { CurrentWeekDay = 5; }
            CurrentPage = Children[CurrentWeekDay];
        }
    }
    class PersonalDayPage : ContentPage
    {
        Day day;
        public PersonalDayPage(Day _day)
        {
            day = _day;
            SKCanvasView can = new SKCanvasView() { BackgroundColor = Color.White};
            can.PaintSurface += OnCanvasViewPaintSurface;
            Content = can;
        }
        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            const float absolutestart = 17/2;
            const float absolutefinish = 22;
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas can = surface.Canvas;
            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = Color.DodgerBlue.ToSKColor(),
                StrokeWidth = 25
            };
            SKPaint subjtextpaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                StrokeWidth = 1,
                TextSize = 50 * info.Width / 1080,
                FakeBoldText = true,
                Color = SKColors.White
            };
            SKPaint timetextpaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                StrokeWidth = 1,
                TextSize = 50*info.Width / 1080,
                FakeBoldText = true,
                Color = SKColors.White
            };
            foreach (Pair item in day.Pairs)
            {
                float start = item.time_start();
                float end = item.time_finish();
                can.DrawRect(0, info.Height / (absolutefinish - absolutestart) * (start - absolutestart),
                info.Width, info.Height / (absolutefinish - absolutestart) * (end - start), paint);
                can.DrawText(item.subject, info.Width /5, info.Height / (absolutefinish - absolutestart) * (start - absolutestart) +
                    (info.Height / (absolutefinish - absolutestart) * (end - start)) / 2, subjtextpaint);
                can.DrawText(item.timestart, 5, info.Height / (absolutefinish - absolutestart) * (start - absolutestart) + timetextpaint.TextSize,
                    timetextpaint);
                can.DrawText(item.timefinish, 5, info.Height / (absolutefinish - absolutestart) * (start - absolutestart) + info.Height / (absolutefinish - absolutestart) * (end - start) - 5,
                    timetextpaint);
                can.DrawText(item.room, info.Width - item.room.Length*40 * info.Width / 1080, info.Height / (absolutefinish - absolutestart) * (start - absolutestart) + info.Height / (absolutefinish - absolutestart) * (end - start) - 5,
                    timetextpaint);

            }
        }
    }
    class UnifiedWeekPage : TabbedPage
    {
        public UnifiedWeekPage()
        {
            int CurrentWeekDay = DateTime.Today.Subtract(new DateTime(2020, 8, 31, 0, 0, 0)).Days % 7;
            string[] days = new string[6];
            days[0] = "пн";
            days[1] = "вт";
            days[2] = "ср";
            days[3] = "чт";
            days[4] = "пт";
            days[5] = "сб";
            for (int i = 0; i < 6; i++)
            {
                UnifiedDayPage day = new UnifiedDayPage(i) { Title = days[i] };
                Children.Add(day);
            }
            if (CurrentWeekDay == 6) { CurrentWeekDay = 5; }
            CurrentPage = Children[CurrentWeekDay];
        }
    }
    class UnifiedDayPage : ContentPage
    {
        public UnifiedDayPage(int _day)
        {
            SKCanvasView can = new SKCanvasView() { BackgroundColor = Color.White, WidthRequest = 600, HeightRequest=1000 };
            Content = new ScrollView {  
                Orientation = ScrollOrientation.Both,
                WidthRequest = 1200,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Always,
                Content = new StackLayout() { Children = { can } },
                
            };
            can.PaintSurface += OnCanvasViewPaintSurface;

            void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
            {
                int spacing = 300;
                const float absolutestart = 17 / 2;
                const float absolutefinish = 22;
                SKImageInfo info = args.Info;
                SKSurface surface = args.Surface;
                SKCanvas canvas = surface.Canvas;
                SKPaint paint = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    Color = Color.DodgerBlue.ToSKColor(),
                    StrokeWidth = 25,
                    TextSize = 80
                };
                int i = 0;
                foreach (var item in  DB.Idiots.Keys)
                {
                    canvas.DrawText(item, 0, (i) * 160+75, paint);
                    foreach (var currentpair in DB.Idiots[item].UniPairs.Days[_day].Pairs)
                    {
                        foreach (var weeknum in currentpair.weeknums)
                        {
                            canvas.DrawRect(spacing+(info.Width-spacing)/(absolutefinish-absolutestart)*(currentpair.time_start()-absolutestart),
                                160*i+150/4*weeknum,
                                (info.Width - spacing) / (absolutefinish - absolutestart) * (currentpair.time_finish()-currentpair.time_start()),150/4,paint);
                        }
                    }
                    canvas.DrawRect(0, 160 * (i + 1) - 9, info.Width, 8, paint);
                    i++;
                }
            }
        }
    }
    class Pair
    {
        public string subject, teacher, room, type, timestart, timefinish;
        public int[] weeknums;
        public Pair(string _subject, string _teacher, string _room, string _type, string _timestart, string _timefinish, int[] _weeknums)
        {
            subject = _subject;
            teacher = _teacher;
            room = _room;
            type = _type;
            timestart = _timestart;
            timefinish = _timefinish;
            weeknums = _weeknums;
        }
        public float time_start()
        {
            return (float.Parse(timestart.Split('.')[0]) + float.Parse(timestart.Split('.')[1]) / 60);
        }
        public float time_finish()
        {
            return (float.Parse(timefinish.Split('.')[0]) + float.Parse(timefinish.Split('.')[1]) / 60);
        }
    }
    class Day
    {
        public List<Pair> Pairs;
        public Day()
        {
            Pairs = new List<Pair>();

        }
    }
    class UNIWeek
    {
        public Day[] Days;
        public UNIWeek()
        {
            Days = new Day[6];
            for (int i = 0; i < 6; i++)
            {
                Days[i] = new Day();
            }
        }
    }
    class STDWeek
    {
        public Day[] Days;
        public STDWeek()
        {
            Days = new Day[6];
            for (int i = 0; i < 6; i++)
            {
                Days[i] = new Day();
            }
        }
    }
    class Idiot
    {
        public UNIWeek UniPairs;
        public STDWeek[] STDWeeks;
        public string Name;
        public Idiot(string name)
        {
            Name = name;
            UniPairs = new UNIWeek();
            STDWeeks = new STDWeek[4];
            for (int i = 0; i < 4; i++)
            {
                STDWeeks[i] = new STDWeek();
            }
        }
        public void AddPair(string pairinfo) // pairinfo:subj+start+finish+room+teacher+day+weeks(..,..,..)+type 
        {
            string[] pairargs = pairinfo.Split('+');
            int[] weeks = Array.ConvertAll(pairargs[6].Split(','), int.Parse);
            Pair currentPair = new Pair(pairargs[0], pairargs[4], pairargs[3], pairargs[7], pairargs[1], pairargs[2], weeks);
            foreach (int week in weeks)
            {
                STDWeeks[week].Days[int.Parse(pairargs[5])-1].Pairs.Add(currentPair);
            }
            UniPairs.Days[int.Parse(pairargs[5])-1].Pairs.Add(currentPair);
        }
    }
    static class DB
    {
        public static Dictionary<string, Idiot> Idiots = new Dictionary<string, Idiot>();
    }
}