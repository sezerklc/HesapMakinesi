namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Numarator(object sender, EventArgs e)
    {
		var b = sender as Button;
        Ekran.Text += b.Text;
		
    }
    

    private void temizle(object sender, EventArgs e)
    {
        Ekran.Text = string.Empty;
    }

    private void SonSil(object sender, EventArgs e)
    {
        if (Ekran.Text.Length > 0)
        {
            Ekran.Text = Ekran.Text.Remove(Ekran.Text.Length - 1);
        }
    }

    private void KareAl(object sender, EventArgs e)
    {
        try
        {
           
            double sayi = Convert.ToDouble(Ekran.Text);

            
            double kareSonucu = sayi * sayi;

            
            Ekran.Text = kareSonucu.ToString();
        }
        catch (Exception)
        {
            Ekran.Text = "Hata: Geçersiz sayý!";
        }
    }

    private void KareKök(object sender, EventArgs e)
    {
        try
        {
           
            double sayi = Convert.ToDouble(Ekran.Text);

           
            double karekokSonucu = Math.Sqrt(sayi);

           
            Ekran.Text = karekokSonucu.ToString();
        }
        catch (Exception)
        {
            Ekran.Text = "Hata: Geçersiz sayý!";
        }
    }

    private void Esittir(object sender, EventArgs e)
    {
        try
        {        
            var hesapla = new System.Data.DataTable();
            double sonuc = Convert.ToDouble(hesapla.Compute(Ekran.Text, string.Empty));
            Ekran.Text = sonuc.ToString();
        }
        catch (Exception)
        {
            Ekran.Text = "Hata: Geçersiz iþlem!";
        }
    }
}