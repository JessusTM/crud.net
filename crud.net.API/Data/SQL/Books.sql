SET IDENTITY_INSERT [db_crud_net].[dbo].[Books] ON;

INSERT INTO [db_crud_net].[dbo].[Books] ([Id], [ISBN], [Title], [Author], [Description], [Language], [PublicationYear], [Pages], [Image], [File], [FileName], [Stock]) 
VALUES 
(1, '978-0-123456-47-2', 'El extranjero', 'Albert Camus', 'Un hombre enfrentado a la indiferencia del universo.', 'Español', 1942, 123, NULL, NULL, NULL, 10),
(2, '978-1-234567-89-5', 'Crimen y castigo', 'Fyodor Dostoevsky', 'Un joven estudiante comete un asesinato y enfrenta las consecuencias.', 'Español', 1866, 430, NULL, NULL, NULL, 5),
(3, '978-0-987654-32-1', '1984', 'George Orwell', 'Una distopía sobre el control totalitario y la opresión.', 'Español', 1949, 328, NULL, NULL, NULL, 8),
(4, '978-1-567890-11-7', 'El viejo y el mar', 'Ernest Hemingway', 'La lucha de un viejo pescador con un enorme marlín.', 'Español', 1952, 128, NULL, NULL, NULL, 7),
(5, '978-0-345678-90-4', 'La metamorfosis', 'Franz Kafka', 'Un hombre se despierta convertido en insecto y enfrenta la incomprensión.', 'Español', 1915, 150, NULL, NULL, NULL, 12),
(6, '978-1-234567-01-0', 'Orgullo y prejuicio', 'Jane Austen', 'Una historia de amor y malentendidos en la Inglaterra del siglo XIX.', 'Español', 1813, 400, NULL, NULL, NULL, 20),
(7, '978-1-234567-23-3', 'Guerra y paz', 'Leo Tolstoy', 'Un épico relato sobre la vida en Rusia durante las Guerras Napoleónicas.', 'Español', 1869, 1225, NULL, NULL, NULL, 4),
(8, '978-1-567890-22-4', 'En busca del tiempo perdido', 'Marcel Proust', 'Una reflexión sobre el tiempo, la memoria y la experiencia.', 'Español', 1913, 1500, NULL, NULL, NULL, 6),
(9, '978-1-345678-33-1', 'Al faro', 'Virginia Woolf', 'Una exploración del tiempo y la memoria a través de una familia.', 'Español', 1927, 320, NULL, NULL, NULL, 9),
(10, '978-0-123456-78-4', 'Moby Dick', 'Herman Melville', 'La obsesión de un capitán por cazar una ballena blanca.', 'Español', 1851, 600, NULL, NULL, NULL, 11),
(11, '978-1-234567-89-0', 'El sonido y la furia', 'William Faulkner', 'La historia de una familia del sur de EE.UU., contada desde perspectivas fragmentadas.', 'Español', 1929, 300, NULL, NULL, NULL, 14),
(12, '978-1-987654-32-8', 'Las uvas de la ira', 'John Steinbeck', 'Una familia pobre durante la Gran Depresión en EE.UU.', 'Español', 1939, 480, NULL, NULL, NULL, 5),
(13, '978-0-123456-91-5', 'Cuentos de Dickens', 'Charles Dickens', 'Una colección de relatos sobre las injusticias sociales en la Inglaterra victoriana.', 'Español', 1850, 250, NULL, NULL, NULL, 10),
(14, '978-1-234567-45-2', 'Cien años de soledad', 'Gabriel García Márquez', 'La historia mágica y trágica de la familia Buendía.', 'Español', 1967, 400, NULL, NULL, NULL, 15),
(15, '978-0-345678-91-8', 'Las aventuras de Huckleberry Finn', 'Mark Twain', 'Las peripecias de un niño en el río Mississippi.', 'Español', 1884, 350, NULL, NULL, NULL, 13),
(16, '978-1-234567-62-9', 'La importancia de llamarse Ernesto', 'Oscar Wilde', 'Una sátira sobre la sociedad victoriana y la identidad.', 'Español', 1895, 160, NULL, NULL, NULL, 12),
(17, '978-1-234567-12-8', 'La llamada de lo salvaje', 'Jack London', 'Un perro salvaje se adapta a la vida en la naturaleza extrema.', 'Español', 1903, 250, NULL, NULL, NULL, 9),
(18, '978-1-234567-02-4', 'Las amistades peligrosas', 'Pierre Choderlos de Laclos', 'Una historia de manipulación y traición en la alta sociedad francesa.', 'Español', 1782, 300, NULL, NULL, NULL, 16),
(19, '978-1-234567-89-2', 'El gran Gatsby', 'F. Scott Fitzgerald', 'Un hombre obsesionado con el sueño americano y su pasado.', 'Español', 1925, 200, NULL, NULL, NULL, 7),
(20, '978-1-234567-03-1', 'La tierra baldía', 'T.S. Eliot', 'Un poema sobre la desesperanza y la alienación en la modernidad.', 'Español', 1922, 150, NULL, NULL, NULL, 11);

SET IDENTITY_INSERT [db_crud_net].[dbo].[Books] OFF;