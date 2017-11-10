using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Java.Util;
using Sample;
using MV = Com.Applandeo.Materialcalendarview;
using System.Linq;

namespace MaterialCalendar
{
    [Activity(Label = "ManyDaysPickerActivity")]
    public class ManyDaysPickerActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.many_days_picker_activity);

            MV.CalendarView calendarView = (MV.CalendarView)FindViewById(Resource.Id.calendarView);

            Button getDateButton = (Button)FindViewById(Resource.Id.getDateButton);
            getDateButton.Click += (sender, e) =>
            {
                calendarView.SelectedDates.ToList().ForEach(d => 
                    Toast.MakeText(this, d.Time.ToString(), ToastLength.Short).Show());
                Toast.MakeText(this, calendarView.SelectedDate.Time.ToString(), 
                               ToastLength.Long).Show();
            };
        }
    }
}
