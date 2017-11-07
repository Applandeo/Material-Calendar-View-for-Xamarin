using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Java.Util;
using Sample;
using MV = Com.Applandeo.Materialcalendarview;

namespace MaterialCalendar
{
    [Activity(Label = "DatePickerActivity")]
    public class OneDayPickerActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.one_day_picker_activity);

            MV.CalendarView calendarView = (MV.CalendarView)FindViewById(Resource.Id.calendarView);

            Calendar min = Calendar.GetInstance(new Locale("PL"));
            min.Add(Calendar.Month, -2);

            Calendar max = Calendar.GetInstance(new Locale("PL"));
            max.Add(Calendar.Month, 2);

            calendarView.SetMinimumDate(min);
            calendarView.SetMaximumDate(max);

            Button getDateButton = (Button)FindViewById(Resource.Id.getDateButton);
            getDateButton.Click += (sender, e) =>
            {
                foreach (Calendar calendar in calendarView.SelectedDates)
                {
                    Toast.MakeText(this, calendar.Time.ToString(),
                                   ToastLength.Short).Show();
                }
            };
        }
    }
}
