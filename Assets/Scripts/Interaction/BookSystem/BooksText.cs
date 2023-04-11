using System.Collections.Generic;

public class BooksText
{
    private List<string> Books = new List<string>()
    {
        ("� ���� ����������� ���� ����� ����� ����� ��������������, �����������, �������. " +
        "\n�� �� � ���� ���, �������� ����� � ������ ���� �� ������ �����! �����!"),
        ("������� ����� ����� ���� � ������ �������, ���� �� �������� ���������� � �����!"),
        ("�� ������ ����������� ��������. ������ ���� ��������, �� ���� � ������!"),
        ("��������� � ������� ����, �� ������ ������, ������ �� ����� �� ����!"),
        ("������ �������� ������� ��� ������� ��� �������� ������!"),
        ("����� � ������ ������� �����. \n�����, ������� �����... �� ��� ��?"),
        ("������ ���� �� ����� �� ������������ ��������� �����, �������� � ��� ������. ��� �� ���� ���������, ����� ���������� ���������� �������... " +
        "������������ ������ �� �������� �������... �� ���������� � �����, " +
        "�� ��������������� � ���������� ������� � ���� ���������, �������, ��� �� ��������� ��� ��� ������������ �����"),
        ("����� ������� � ����� ���������� ��������� ���� ����������. " +
        "��� ������ ��� ����� ������? �����-���� �������, � ���������� ����� ��������� �������. ������ ���-�� ����..."),
        ("����� ������� ������ � ��������. \n�� � ����� ������� ���������. \n������ �� �������� ���� ����!"),
        ("����������� ��������. ���������� ��� ��������, �� � � �� ��������� � ����! ������� ��� ��� ������������� ����! "),
    };

    public string GetBookText(int number)
    {
        var books = Books;
        return books[number];
    }
}