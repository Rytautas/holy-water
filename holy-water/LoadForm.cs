namespace holy_water
{
    class LoadForm
    {
      public void openinput()
        {
            BarList barList = new BarList();
            barList.Show();
        }
      public void openstats()
        {
            ViewStatistics st = new ViewStatistics();
            st.Show();
        }
    }
}
