public class Autorepuesto
{
    public string Nombre { get; set; }
    public string Codigo { get; set; }
    public decimal Precio { get; set; }
    public string Marca { get; set; }
}


public class RepuestoMecanico : Autorepuesto
{
    public string Material { get; set; }
}
public class Motor : RepuestoMecanico
{
    public int CaballosDeFuerza { get; set; }
    public string TipoCombustible { get; set; }
}


public class Transmision : RepuestoMecanico
{
    public string Tipo { get; set; } 
    public int Velocidades { get; set; }
}

public class RepuestoElectrico : Autorepuesto
{
    public int Voltaje { get; set; }
}
public class Bateria : RepuestoElectrico
{
    public int CapacidadAmperios { get; set; }
}

public class Alternador : RepuestoElectrico
{
    public int Amperaje { get; set; }
}
public class Accesorio : Autorepuesto
{
    public bool EsOriginal { get; set; }
}
public class Espejo : Accesorio
{
    public bool EsElectrico { get; set; }
}
public class Limpiaparabrisas : Accesorio
{
    public int TamañoPulgadas { get; set; }
}



