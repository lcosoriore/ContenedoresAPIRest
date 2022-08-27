CREATE TABLE `Statistics` (
  `idStatistics` int NOT NULL AUTO_INCREMENT,
  `budgetused` decimal(65,0) DEFAULT NULL,
  `containersdispatched` decimal(65,0) DEFAULT NULL,
  `containersnotdispatched` decimal(65,0) DEFAULT NULL,
  PRIMARY KEY (`idStatistics`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
