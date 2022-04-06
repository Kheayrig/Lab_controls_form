using System;

namespace InterfaceLoadPrintSort
{
    public interface ILoadPrintSort
    {
        string[] Print();
        void Load(string fileName);
        void SortByName();
        void SortByValue();
    }














    /*public static class StringExtension
{
    public static int CharCount(this string str, char c)
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }
 }*/
/*public class Processor
{
    public List<Type> GetTypes(Assembly asm)
    {
        if (asm == null)
        {
            throw new ArgumentNullException("Передана пустая сборка");
        }

        var types = asm.GetTypes().ToList(); 
        types = types;
        return types;
    }

    public List<Type> GetInterfaces(Assembly asm)
    {
        var types = GetTypes(asm);
        return (new List<Type>(types.Where(t => t.IsInterface)));
    }

    public string GetTypeDescription(Type t)
    {
        string outp = "";
        if (t.IsClass)
        {
            outp += "Class" + '\n';
        }
        else if (t is Delegate)//??
        {
            outp += "Delegate" + '\n';
        }
        else if(t.IsInterface)
        {
            outp += "Interface" + '\n';
        }
        else if(t.IsEnum)
        {
            outp += "Enum" + '\n';
        }
        else
        {
            outp += "Other" + '\n';
        }

            outp += "***** Fields *****" + '\n';
        var fieldNames = from f in t.GetFields() select f.Name;
        foreach (var name in fieldNames)
            outp += name + '\n';
        outp += "***** Methods *****" + '\n';
        var methodsNames = from f in t.GetMethods() select f;
        foreach (var name in methodsNames)
            outp += name.ReturnType + " "+name.Name + '\n';
        outp += "***** Properties *****" + '\n';
        var propNames = from p in t.GetProperties() select p.Name;
        foreach (var name in propNames)
            outp += name + '\n';
        outp += "Interfaces" + '\n';
        var ifaces = from i in t.GetInterfaces() select i;
        foreach (Type i in ifaces)
            outp += i.Name + '\n'; ;
        return outp;
    }*/
/*asm = null;
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                asm = Assembly.LoadFrom(opf.FileName);
            }
Processor proc = new Processor();
var t = proc.GetTypes(asm);
label1.Text = proc.GetTypeDescription((t[listBox1.SelectedIndex]));*/
//Random rnd = new Random();
//        public event AccountEventHandler BalanceChanged;
//BalanceChanged?.Invoke(this, new AccountEventArgs($"На счет {Id} положена сумма {sum}, баланс: {Balance}"));



/*private void Item_BalanceChanged(object sender, AccountEventArgs e)
    {
        Console.WriteLine(e.Message);
    }*/
}
