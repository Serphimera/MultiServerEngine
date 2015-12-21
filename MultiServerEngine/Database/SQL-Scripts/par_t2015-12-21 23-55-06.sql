USE msepdb;

CREATE TABLE `par_t` (
  `PARGRP` varchar(16) NOT NULL COMMENT 'parameter group within parameter component',
  `PARCOMPGRP` varchar(16) NOT NULL COMMENT 'parameter component group',
  `PARKEY` varchar(16) NOT NULL COMMENT 'parameter key',
  `PARVALUE` varchar(255) DEFAULT NULL COMMENT 'parameter value',
  `PARVALUEMAX` varchar(255) DEFAULT NULL COMMENT 'maximum parameter value',
  `PARVALUEMIN` varchar(255) DEFAULT NULL COMMENT 'minimum parameter value',
  `PARTYPE` decimal(3,0) DEFAULT NULL COMMENT 'type of parameter (e.g. number, string, date, time)',
  `PARDESC` varchar(80) DEFAULT NULL COMMENT 'real name of parameter',
  `PARINFO` text CHARACTER SET latin1 COMMENT 'description of parameter',
  `DTINS` datetime DEFAULT NULL COMMENT 'datetime of insert',
  `DTUPD` datetime DEFAULT NULL COMMENT 'datetime of last update',
  `TSN` decimal(8,0) DEFAULT NULL COMMENT 'transaction sequence number',
  `NAMUPD` varchar(35) DEFAULT NULL COMMENT 'name of last updater',
  PRIMARY KEY (`PARCOMPGRP`,`PARGRP`,`PARKEY`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 CHECKSUM=1;


insert into `par_t`(`PARGRP`,`PARCOMPGRP`,`PARKEY`,`PARVALUE`,`PARVALUEMAX`,`PARVALUEMIN`,`PARTYPE`,`PARDESC`,`PARINFO`,`DTINS`,`DTUPD`,`TSN`,`NAMUPD`) values ('LoginServer','Server','IPAddress','127.0.0.1','127.0.0.200','127.0.0.1',10,'LoginServer IP-Address','The IP-Address of the LoginServer','2015-12-21 21:29:00','2015-12-21 21:29:00',1,'Init');
insert into `par_t`(`PARGRP`,`PARCOMPGRP`,`PARKEY`,`PARVALUE`,`PARVALUEMAX`,`PARVALUEMIN`,`PARTYPE`,`PARDESC`,`PARINFO`,`DTINS`,`DTUPD`,`TSN`,`NAMUPD`) values ('LoginServer','Server','TcpPort','4531','4530','4550',20,'LoginServer TcpPort','The TcpPort for connections of Servers','2015-12-21 21:29:00','2015-12-21 21:29:00',1,'Init');
insert into `par_t`(`PARGRP`,`PARCOMPGRP`,`PARKEY`,`PARVALUE`,`PARVALUEMAX`,`PARVALUEMIN`,`PARTYPE`,`PARDESC`,`PARINFO`,`DTINS`,`DTUPD`,`TSN`,`NAMUPD`) values ('MasterServer','Server','IPAddress','127.0.0.1','127.0.0.200','127.0.0.1',10,'MasterServer IP-Address','The IP-Address of the MasterServer each SubServer and Client connect to','2015-12-21 21:29:00','2015-12-21 21:29:00',1,'Init');
insert into `par_t`(`PARGRP`,`PARCOMPGRP`,`PARKEY`,`PARVALUE`,`PARVALUEMAX`,`PARVALUEMIN`,`PARTYPE`,`PARDESC`,`PARINFO`,`DTINS`,`DTUPD`,`TSN`,`NAMUPD`) values ('MasterServer','Server','TcpPort','4520','4500','6000',20,'MasterServer TcpPort','The TcpPort for connections of SubServers','2015-12-21 21:29:00','2015-12-21 21:29:00',1,'Init');
