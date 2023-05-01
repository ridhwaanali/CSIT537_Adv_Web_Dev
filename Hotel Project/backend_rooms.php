<?php

require_once '_db.php';

$stmt=$db->prepare("select * from rooms ORDER BY u name");

$stmt->execute();

$rooms-$stmt->fetchALL();

class room{}

<?php

require_once '_db.php';

$stmt=$db->prepare("select * from rooms ORDER BY u name");

$stmt->execute();

$rooms-$stmt->fetchALL();

class room{}

$result=array();

foreach($rooms as $room){

$r=new room();

$r->id=$room['id'];

$r->name=$room['name'];

$result[]=$r;

}

header('content-type:application/json);

echo json_encode($result)');

?>

dp.rowHeaderColumns=[

{title:"room",width:60},

{title:"name",width:60}

];

<?php

require_once '_db_sqlite.php';

<?php
