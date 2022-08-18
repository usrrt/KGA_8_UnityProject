using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CsvHelper;
using System;
using System.IO;
using CsvHelper.Configuration;
using System.Globalization;


public class TestCsvRecord
{
    public int ID { get; set; }

    public string Name { get; set; }

}


public class temp : MonoBehaviour
{
    private void Start()
    {
        // 1. Resources ������ �ִ� CSV������ TestAsset���� �ε�
        TextAsset tempText = Resources.Load<TextAsset>("Csv/CSV����");

        // 2. CSV���� ����
        CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            
            Delimiter = "|",
            NewLine = Environment.NewLine, // �÷��� ȯ�濡 �´� ���๮�� ��� ����
            
        };

         // 3. CSV �Ľ�
        using(StringReader csvString = new StringReader(tempText.text)) // ��ȣ�ȿ� IDisposable�����ϰ��ִ� ��ü�� �־��ش�
        {
            using (CsvReader csv = new CsvReader(csvString, config))
            {
                IEnumerable<TestCsvRecord> records = csv.GetRecords<TestCsvRecord>();
                foreach (TestCsvRecord record in records) //IEnumerable �̹Ƿ� foreach��밡�� -> �Ϲ�ȭ �÷��ǳ���
                {
                    Debug.Log($"{record.ID} : {record.Name}");
                } // ���������� �ɼ��ֱ⿡ �ð��� �����ɸ����ִ�.
            }
        } // ��Ϲ����� ����� Dispose�� �ڵ��� ȣ���� 


    } 
    
}
