/*
create database NguyenMinhTuanLab11;

CREATE TABLE NmitEmployee (
    NmitEmpId INT PRIMARY KEY,
    NmitEmpName NVARCHAR(100),
    NmitEmpLevel NVARCHAR(50),
    NmitEmpStartDate DATE,
    NmitEmpStatus BIT  -- kiểu boolean trong SQL Server là BIT
);

insert into NmitEmployee values( 1, N'Nguyen Minh Tuan', N'Advenced', '2005-04-02', 1),
								( 2, N'Kim Ngoc Tam', N'Advenced', '2005-04-02', 1),
								( 3, N'Nguyen Van Khai', N'Advenced', '2005-04-02', 0),
								( 4, N'Nguyen Huong Tra', N'Middle', '2005-04-02', 1),
								( 5, N'Nguyen Linh Chi', N'middle', '2005-04-02', 0);

select * from NmitEmployee;
*/