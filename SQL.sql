CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Address NVARCHAR(200),
    Phone NVARCHAR(20),
    Email NVARCHAR(100)
);
INSERT INTO Customers (Name, Address, Phone, Email)
VALUES 
(N'Công ty Vận tải A', N'123 Lê Lợi, Hà Nội', '0912345678', 'contact@vantaia.com'),
(N'Nguyễn Văn B', N'45 Trần Phú, TP.HCM', '0987654321', 'nguyenb@example.com'),
(N'Công ty Giao hàng C', N'78 Pasteur, Đà Nẵng', '0909090909', 'giaohangc@ship.com'),
(N'Lê Thị D', N'12 Hai Bà Trưng, Cần Thơ', '0933888999', 'lethid@outlook.com');
