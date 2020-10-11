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
            DB.Idiots["Даня"].AddPair("Введение в структуры данных+12.20+13.45+702 КПМ++2+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Введение в структуры данных+13.55+15.20+702 КПМ++2+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Иностранный язык+15.30+16.55+++2+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Аналитическая геометрия+10.45+12.10+Онлайн+Подлипский О.К.+3+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Математическая логика+12.20+13.45+Онлайн+Дашков Е.В.+3+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Введение в математический анализ+13.55+15.20+Онлайн+Редкозубов В.В+3+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Введение в математический анализ+09.00+10.25+Онлайн++4+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Введение в программирование и алгоритмы+13.55+15.20+Онлайн++4+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("История+18.35+20.00+Онлайн++4+0,1,2,3+Лекция");
            DB.Idiots["Даня"].AddPair("Аналитическая геометрия+12.20+13.45+420 ГК++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Иностранный язык+13.55+15.20+++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Введение в структуры данных+17.05+18.30+УЛК 2 №425++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Введение в структуры данных+18.35+20.00+УЛК 2 №425++5+0,1,2,3+Семинар");
            DB.Idiots["Даня"].AddPair("Физкультура+10.45+12.10+++6+0,1,2,3+Семинар");

            DB.Idiots["Паша"] = new Idiot("Паша");
            DB.Idiots["Паша"].AddPair("Физкультура+09.00+10.25+++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Математический анализ+10.45+12.10+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Математический анализ+12.20+13.45+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Иностранный язык+13.55+15.20+315 НК++1+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Введение в математический анализ+10.45+12.10+Онлайн+Редкозубова Е.Ю.+2+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Аналитическая геометрия+12.20+13.45+Онлайн+Ершов А.В.+2+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Биология клетки+13.55+15.20+Онлайн+Носов Г.А.+2+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Общая биологическая лабораторная практика+10.45+12.10+217 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Паша"].AddPair("Физкультура+13.55+15.20+++3+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Общая и неорганическая химия+15.30+16.55+409 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Аналитическая геометрия+17.05+18.30+411 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Биология клетки+10.45+12.10+516а ГК++4+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Иностранный язык+15.30+16.55+315 НК++4+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Практикум по основам общей и неорганической химии+17.05+18.30+210 БК++4+0,1,2,3+Лабораторная работа");
            DB.Idiots["Паша"].AddPair("Практикум по основам общей и неорганической химии+18.35+20.00+210 БК++4+0,1,2,3+Лабораторная работа");
            DB.Idiots["Паша"].AddPair("Введение в математический анализ+09.00+10.25+Онлайн+Редкозубова Е.Ю.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Общая биология+10.45+12.10+Онлайн+Скобеева В.А.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Основы общей и неорганической химии+13.55+15.20+Онлайн+Инденбом А.В.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("История+15.30+16.55+Онлайн+Суриков И.Е.+5+0,1,2,3+Лекция");
            DB.Idiots["Паша"].AddPair("Практика программирования с использованием Python+09.00+10.25+705 КПМ++6+0,1,2,3+Семинар");
            DB.Idiots["Паша"].AddPair("Практика программирования с использованием Python+10.45+12.10+705 КПМ++6+0,1,2,3+Семинар");

            DB.Idiots["Ксюша"] = new Idiot("Ксюша");
            DB.Idiots["Ксюша"].AddPair("Физкультура+09.00+10.25+++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Математический анализ+10.45+12.10+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Математический анализ+12.20+13.45+426 ГК++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Иностранный язык+13.55+15.20+325 НК++1+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Введение в математический анализ+10.45+12.10+Онлайн+Редкозубова Е.Ю.+2+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Аналитическая геометрия+12.20+13.45+Онлайн+Ершов А.В.+2+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Биология клетки+13.55+15.20+Онлайн+Носов Г.А.+2+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Общая биологическая лабораторная практика+09.00+10.25+217 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Ксюша"].AddPair("Общая и неорганическая химия+12.20+13.45+210 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Практикум по основам общей и неорганической химии+13.55+15.20+211 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Ксюша"].AddPair("Практикум по основам общей и неорганической химии+15.30+16.55+211 БК++3+0,1,2,3+Лабораторная работа");
            DB.Idiots["Ксюша"].AddPair("Аналитическая геометрия+17.05+18.30+210 ГК++3+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Физкультура+10.45+12.10+++4+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Биология клетки+12.20+13.45+426 ГК++4+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Иностранный язык+13.55+15.20+325 НК++4+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Введение в математический анализ+09.00+10.25+Онлайн+Редкозубова Е.Ю.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Общая биология+10.45+12.10+Онлайн+Скобеева В.А.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Основы общей и неорганической химии+13.55+15.20+Онлайн+Инденбом А.В.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("История+15.30+16.55+Онлайн+Суриков И.Е.+5+0,1,2,3+Лекция");
            DB.Idiots["Ксюша"].AddPair("Практика программирования с использованием Python+09.00+10.25+702 КПМ++6+0,1,2,3+Семинар");
            DB.Idiots["Ксюша"].AddPair("Практика программирования с использованием Python+10.45+12.10+702 КПМ++6+0,1,2,3+Семинар");

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
                        Items = { new ShellContent {Content = new UnifiedWeekPage()} }
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

        }
    }
    class PersonalPage : TabbedPage
    {
        public PersonalPage(Idiot idiot)
        {
            for (int i = 0; i < 4; i++)
            {
                PersonalWeekPage weekpage = new PersonalWeekPage(idiot.STDWeeks[i]) { Title = (i+1).ToString() };
                Children.Add(weekpage);
            }
        }
    }
    class PersonalWeekPage : TabbedPage
    {
        public PersonalWeekPage(STDWeek week)
        {
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
                can.DrawText(item.room, info.Width - item.room.Length*30 * info.Width / 1080, info.Height / (absolutefinish - absolutestart) * (start - absolutestart) + info.Height / (absolutefinish - absolutestart) * (end - start) - 5,
                    timetextpaint);

            }
        }
    }
    class UnifiedWeekPage : TabbedPage
    {
        public UnifiedWeekPage()
        {
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
        }
    }
    class UnifiedDayPage : ContentPage
    {
        public UnifiedDayPage(int _day)
        {
            SKCanvasView can = new SKCanvasView() { BackgroundColor = Color.White, WidthRequest = 800, HeightRequest=1500 };
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