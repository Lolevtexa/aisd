#include "Student.h"
#include "Sort.h"
#include <iostream>

int main() {
    int max_students;
    std::cout << "Введите максимальное количество студентов: ";
    std::cin >> max_students;
    std::cin.ignore();

    Student* students = new Student[max_students];
    int student_count = 0;

    char command;
    bool running = true;
    while (running) {
        std::cout << "1. Добавить студента\n"
                     "2. Показать студентов\n"
                     "3. Сортировка пузырьком\n"
                     "4. Сортировка выбором\n"
                     "5. Быстрая сортировка\n"
                     "6. Пирамидальная сортировка\n"
                     "7. Выход\n"
                     "Введите ваш выбор: ";
        std::cin >> command;
        std::cin.ignore();
        switch (command) {
            case '1':
                add_student(students, student_count, max_students);
                break;
            case '2':
                print_students(students, student_count);
                break;
            case '3':
                bubble_sort(students, student_count);
                break;
            case '4':
                selection_sort(students, student_count);
                break;
            case '5':
                quick_sort(students, student_count);
                break;
            case '6':
                heap_sort(students, student_count);
                break;
            case '7':
                running = false;
                break;
            default:
                std::cout << "Неверный ввод, попробуйте снова.\n";
        }
    }

    delete[] students; // Освобождение выделенной памяти
    return 0;
}
