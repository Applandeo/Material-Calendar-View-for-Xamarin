using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using Com.Applandeo.Materialcalendarview;
using MCV = Com.Applandeo.Materialcalendarview;
using Java.Util;
using Sample;
using Android.Support.V7.App;

namespace MaterialCalendar
{
    [Activity(Label = "MaterialCalendar", MainLauncher = true, Icon = "@mipmap/icon")]
    public class CalendarActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.calendar_activity);

            List<EventDay> events = new List<EventDay>();

            Calendar calendar = Calendar.GetInstance(new Locale("PL"));
            events.Add(new EventDay(calendar, Resource.Drawable.sample_icon_1));

            Calendar calendar1 = Calendar.GetInstance(new Locale("PL"));
            calendar1.Add(Calendar.DayOfMonth, 2);
            events.Add(new EventDay(calendar1, Resource.Drawable.sample_icon_2));

            Calendar calendar2 = Calendar.GetInstance(new Locale("PL"));
            calendar2.Add(Calendar.DayOfMonth, 5);
            events.Add(new EventDay(calendar2, Resource.Drawable.sample_icon_3));

            MCV.CalendarView calendarView = (MCV.CalendarView)FindViewById(Resource.Id.calendarView);

            calendarView.PreviousButtonClick += (sender, e) => 
                Toast.MakeText(this, "LEWO", ToastLength.Short).Show();

            calendarView.ForwardButtonClick += (sender, e) => 
                Toast.MakeText(this, "PRAWO", ToastLength.Short).Show();

            Calendar min = Calendar.GetInstance(new Locale("PL"));
            min.Add(Calendar.Month, -2);

            Calendar max = Calendar.GetInstance(new Locale("PL"));
            max.Add(Calendar.Month, 2);

            calendarView.SetMinimumDate(min);
            calendarView.SetMaximumDate(max);

            calendarView.SetEvents(events);

            calendarView.DayClick += (sender, e) => 
            {
                Toast.MakeText(this, e.P0.Calendar.Time.ToString(),
                               ToastLength.Short).Show();
            };

            Button setDateButton = (Button)FindViewById(Resource.Id.setDateButton);
            setDateButton.Click += (sender, e) => 
            {
                calendarView.SetDate(GetRandomCalendar());
            };
        }

        private Calendar GetRandomCalendar()
        {
            Random random = new Random();

            Calendar calendar = Calendar.GetInstance(new Locale("PL"));
            calendar.Add(CalendarField.Month, random.NextInt(99));

            return calendar;
        }
    }
}
