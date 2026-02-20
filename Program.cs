namespace Uveghazrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Adattar adattar = new Adattar();

			adattar.UjNoveny(new NovenyFaj("Uborka", 5));
			adattar.UjNoveny(new NovenyFaj("Sárgarépa", 6));
			adattar.UjNoveny(new NovenyFaj("Burgonya", 4));
			adattar.UjNoveny(new NovenyFaj("Hagyma", 7));
			adattar.UjNoveny(new NovenyFaj("Fokhagyma", 8));
			adattar.UjNoveny(new NovenyFaj("Saláta", 5));
			adattar.UjNoveny(new NovenyFaj("Kukorica", 3));
			adattar.UjNoveny(new NovenyFaj("Borsó", 6));
			adattar.UjNoveny(new NovenyFaj("Bab", 5));
			adattar.UjNoveny(new NovenyFaj("Káposzta", 4));
			adattar.UjNoveny(new NovenyFaj("Karfiol", 4));
			adattar.UjNoveny(new NovenyFaj("Brokkoli", 4));
			adattar.UjNoveny(new NovenyFaj("Cukkini", 5));
			adattar.UjNoveny(new NovenyFaj("Spenót", 7));

			adattar.NovenyekListazasa();
		}
    }
}
