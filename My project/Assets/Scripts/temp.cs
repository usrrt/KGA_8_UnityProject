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
        // 1. Resources 폴더에 있는 CSV파일을 TestAsset으로 로드
        TextAsset tempText = Resources.Load<TextAsset>("Csv/CSV연습");

        // 2. CSV파일 설정
        CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            
            Delimiter = "|",
            NewLine = Environment.NewLine, // 플랫폼 환경에 맞는 개행문자 사용 정의
            
        };

         // 3. CSV 파싱
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
        } // 블록범위를 벗어날때 Dispose를 자동을 호출함 


    } 
    
}
