using Android.App;
using Android.OS;
using Java.Util;
using Com.Applandeo.Materialcalendarview.Listeners;
using Android.Support.V7.App;
using Android.Content;
using MC = Com.Applandeo.Materialcalendarview;
using MCVB = Com.Applandeo.Materialcalendarview.Builders;
using System.Collections.Generic;
using Com.Applandeo.Materialcalendarview;
using Android.Widget;
using Sample;
using System.Linq;

namespace MaterialCalendar
{
    [Activity(Label = "MaterialCalendar", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity, IOnSelectDateListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Button openCalendarButton = (Button)FindViewById(Resource.Id.openCalendarButton);

            openCalendarButton.Click += (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(CalendarActivity));
                StartActivity(intent);
            };

            Button openOneDayPicker = (Button)FindViewById(Resource.Id.openOneDayPickerButton);
            openOneDayPicker.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(OneDayPickerActivity)));
            };

            Button openManyDaysPicker = (Button)FindViewById(Resource.Id.openManyDayPickerButton);
            openManyDaysPicker.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(ManyDaysPickerActivity)));
            };

            Button openRangePicker = (Button)FindViewById(Resource.Id.openRangePickerButton);
            openRangePicker.Click += (sender, e) =>
            {
                StartActivity(new Intent(this, typeof(RangePickerActivity)));
            };

            Calendar min = Calendar.GetInstance(new Locale("PL"));
            min.Add(CalendarField.Month, -5);

            Calendar max = Calendar.GetInstance(new Locale("PL"));
            max.Add(CalendarField.Month, -3);

            MCVB.DatePickerBuilder oneDayBuilder = new MCVB.DatePickerBuilder(this, this)
                .PickerType(MC.CalendarView.OneDayPicker)
                .Date(max)
                .HeaderColor(Resource.Color.colorPrimaryDark)
                .HeaderLabelColor(Resource.Color.currentMonthDayColor)
                .SelectionColor(Resource.Color.daysLabelColor)
                .TodayLabelColor(Resource.Color.colorAccent)
                .DialogButtonsColor(Android.Resource.Color.HoloGreenDark)
                .PreviousButtonSrc(Resource.Drawable.ic_chevron_left_black_24dp)
                .ForwardButtonSrc(Resource.Drawable.ic_chevron_right_black_24dp)
                .MinimumDate(min)
                .MaximumDate(max);

            MC.DatePicker oneDayPicker = oneDayBuilder.Build();

            Button openOneDayPickerDialog = (Button)FindViewById(Resource.Id.openOneDayPickerDialogButton);
            openOneDayPickerDialog.Click += (sender, e) => oneDayPicker.Show();

            MCVB.DatePickerBuilder manyDaysBuilder = new MCVB.DatePickerBuilder(this, this)
                .PickerType(MC.CalendarView.ManyDaysPicker)
                .HeaderColor(Android.Resource.Color.HoloGreenDark)
                .SelectionColor(Android.Resource.Color.HoloGreenDark)
                .TodayLabelColor(Android.Resource.Color.HoloGreenDark)
                .DialogButtonsColor(Android.Resource.Color.HoloGreenDark);

            MC.DatePicker manyDayPicker = manyDaysBuilder.Build();


            Button openManyDaysPickerDialog = (Button)FindViewById(Resource.Id.openManyDaysPickerDialogButton);
            openManyDaysPickerDialog.Click += (sender, e) => manyDayPicker.Show();

            MCVB.DatePickerBuilder rangeBuilder = new MCVB.DatePickerBuilder(this, this)
                .PickerType(MC.CalendarView.RangePicker)
                .HeaderColor(Android.Resource.Color.HoloGreenDark)
                .SelectionColor(Android.Resource.Color.HoloGreenDark)
                .TodayLabelColor(Android.Resource.Color.HoloGreenDark)
                .DialogButtonsColor(Android.Resource.Color.HoloGreenDark);

            MC.DatePicker rangePicker = rangeBuilder.Build();

            Button openRangePickerDialog = (Button)FindViewById(Resource.Id.openRangePickerDialogButton);
            openRangePickerDialog.Click += (sender, e) => rangePicker.Show();
        }

        public void OnSelect(Calendar calendar)
        {
            Toast.MakeText(this, calendar.Time.ToString(), ToastLength.Long).Show();
        }

        private Calendar GetRandomCalendar()
        {
            Random random = new Random();

            Calendar calendar = Calendar.GetInstance(new Locale("PL"));
            calendar.Add(CalendarField.Month, random.NextInt(99));

            return calendar;
        }

        public void OnSelect(IList<Calendar> calendars)
        {
            calendars.ToList().ForEach(c => 
               Toast.MakeText(this, c.Time.ToString(), ToastLength.Short).Show());
        }
    }
}
