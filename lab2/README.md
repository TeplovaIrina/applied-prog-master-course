# Постановка задачи
Разработка приложения, обеспечивающего формирование документа в форматах Excel, XML/JSON, TXT с использованием шаблона «Фабрика».

## Выгрузка в Excel
Для выгрузки в Excel при разработке на языке C# рекомендуется использовать библиотеку DocumentFormat.OpenXML

Описание работы и примеров с ней - https://msdn.microsoft.com/ru-ru/library/office/hh180830(v=office.14).aspx

Для формирования Excel файлов на других языках, необходимо произвести самостоятельный поиск библиотек/расширений для формирования данных в формате Office OpenXML

### Office Open XML
https://ru.wikipedia.org/wiki/Office_Open_XML

Это формат данных, для описания файлов пакета программ Microsoft Office.

Возможно, для работы понадобится программа OpenXML SDK, которая позволяет "отладить" офисный файл.

##Выгрузка в XML/JSON
Практически во всех языках есть встроенные функции конвертирования в эти форматы.

Выгружаемый класс
`````
public class Class1
{
	public int Id { get; set; }
	public string Name { get; set; }
}
`````

XML
`````
<class1>
	<Id value="5" />
	<Name value="test" />
</class1>
`````

JSON
`````
{
	Id : 5,
	Name : 'test'
}
`````