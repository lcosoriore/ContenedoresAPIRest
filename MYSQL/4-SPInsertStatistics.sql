CREATE DEFINER=`root`@`%` PROCEDURE `InsertStatistics`(
Vbudgetused decimal(65),
Vcontainersdispatched decimal(65),
Vcontainersnotdispatched decimal(65)
)
BEGIN
INSERT INTO `Containers`.`Statistics`
(`budgetused`,
`containersdispatched`,
`containersnotdispatched`)
VALUES
(Vbudgetused,
Vcontainersdispatched,
Vcontainersnotdispatched);
END