﻿using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using MCV = Com.Applandeo.Materialcalendarview;
using Java.Util;
using Sample;
using Android.Support.V7.App;
using Com.Applandeo.Materialcalendarview.Exceptions;
using MaterialCalendarView;
using Com.Applandeo.Materialcalendarview;

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

            Calendar calendarToday = Calendar.Instance;
            events.Add(new EventDay(calendarToday, Resource.Drawable.sample_icon_1));

            Calendar calendarTwoDaysFromToday = Calendar.Instance;
            calendarTwoDaysFromToday.Add(CalendarField.DayOfMonth, 2);
            events.Add(new EventDay(calendarTwoDaysFromToday, Resource.Drawable.sample_icon_2));

            calendarToday.ToDateTime();
            Calendar calendarFiveDaysFromToday = Calendar.Instance;
            calendarFiveDaysFromToday.Add(CalendarField.DayOfMonth, 5);
            events.Add(new EventDay(calendarFiveDaysFromToday, Resource.Drawable.sample_icon_3));

            MCV.CalendarView calendarView = (MCV.CalendarView)FindViewById(Resource.Id.calendarView);

            calendarView.PreviousButtonClick += (sender, e) => 
                Toast.MakeText(this, "LEFT", ToastLength.Short).Show();

            calendarView.ForwardButtonClick += (sender, e) => 
                Toast.MakeText(this, "RIGHT", ToastLength.Short).Show();

            Calendar min = Calendar.Instance;
            min.Add(CalendarField.Month, -2);

            Calendar max = Calendar.Instance;
            max.Add(CalendarField.Month, 2);

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
                try
                {
                    calendarView.SetDate(GetRandomCalendar());
                }
                catch (OutOfDateRangeException exception)
                {
                    exception.PrintStackTrace();
                    Toast.MakeText(this, "Date is out of range", ToastLength.Short).Show();
                }
            };
        }

        private Calendar GetRandomCalendar()
        {
            Random random = new Random();

            Calendar calendar = Calendar.Instance;
            calendar.Add(CalendarField.Month, random.NextInt(99));

            return calendar;
        }
    }
}
