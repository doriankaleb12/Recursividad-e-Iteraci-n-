#include <iostream>
#include <string>

int main() {
    int NUM, I, RESUL;
    std::string linea;

    std::cout << "DIGITE UN NUMERO: ";
    std::cin >> linea;

    // Convierte la entrada del usuario a un número entero
    NUM = std::stoi(linea);

    I = 1;
    while (I <= 12) {
        RESUL = NUM * I;
        std::cout << NUM << " * " << I << " = " << RESUL << std::endl;
        I = I + 1;
    }

    std::cout << "Pulse Enter para salir...";
    std::cin.ignore();
    std::cin.get();

    return 0;
}