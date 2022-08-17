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
        // TextAsset: 텍스트 파일 불러오기
        // Text파일 or 바이너리 파일
        TextAsset tempText = Resources.Load<TextAsset>("Csv/CSV연습");

        CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            
            Delimiter = "|",
            NewLine = Environment.NewLine, // 개행문자 신경안쓰고 어쩌거 
            
        };

         // 파싱준비완료
        using(StringReader csvString = new StringReader(tempText.text)) // 괄호안에 IDisposable구현하고있는 객체를 넣어준다
        {
            using (CsvReader csv = new CsvReader(csvString, config))
            {
                IEnumerable<TestCsvRecord> records = csv.GetRecords<TestCsvRecord>();
                foreach (TestCsvRecord record in records) //IEnumerable 이므로 foreach사용가능 -> 일반화 컬렉션내용
                {
                    Debug.Log($"{record.ID} : {record.Name}");
                } // 병목지점이 될수있기에 시간이 오래걸릴수있다.
            }
        } // 블록범위를 벗어날때 Dispose 를ㄹ 자동을 호출함 

        // 명시적으로 닫는 메소드 호출
        //csv.Dispose();
        //csvString.Dispose();
        // 귀찮고 잊어비리는 실수존재 따라서 using구문으로 자동으로호출하게해줘야한다

    } // 파싱완료
    
}
