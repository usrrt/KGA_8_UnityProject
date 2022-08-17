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
        // TextAsset: �ؽ�Ʈ ���� �ҷ�����
        // Text���� or ���̳ʸ� ����
        TextAsset tempText = Resources.Load<TextAsset>("Csv/CSV����");

        CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            
            Delimiter = "|",
            NewLine = Environment.NewLine, // ���๮�� �Ű�Ⱦ��� ��¼�� 
            
        };

         // �Ľ��غ�Ϸ�
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
        } // ��Ϲ����� ����� Dispose ���� �ڵ��� ȣ���� 

        // ��������� �ݴ� �޼ҵ� ȣ��
        //csv.Dispose();
        //csvString.Dispose();
        // ������ �ؾ�񸮴� �Ǽ����� ���� using�������� �ڵ�����ȣ���ϰ�������Ѵ�

    } // �Ľ̿Ϸ�
    
}
