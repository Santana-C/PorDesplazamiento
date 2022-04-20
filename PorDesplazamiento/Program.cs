Console.WriteLine("CIFRADO POR DESPLAZAMIENTO\n");
Console.WriteLine("Ingrese el mensaje:");
string mensaje = Console.ReadLine().Trim().ToUpper();
Console.WriteLine("\nIngrese la llave:");
int Llave = int.Parse(Console.ReadLine());
string mensajeCifrado = Cifrar(mensaje, Llave);
Console.WriteLine("\nMensaje Cifrado: " + mensajeCifrado);
string MensajeClaro = Descifrar(mensajeCifrado, Llave);
Console.WriteLine("\nMensaje Descifrado: " + MensajeClaro);
string Cifrar(string mensajeClaro, int llave) {
    string criptograma = "";
    foreach(char caracter in mensajeClaro) criptograma += (char) (((caracter - 65 + llave) % 26) + 65);
    return criptograma;
}
string Descifrar(string criptograma, int llave) {
    llave = (26 - llave) % 26;
    return Cifrar(criptograma, llave);
}