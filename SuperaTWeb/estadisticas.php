<?php

	$server = "localhost";
	$user = "root";
	$pass = "";
	$database = "superat";

	$connect = new mysqli($server, $user, $pass, $database);

	if (!$connect) {
		echo "ERROR";
	} else {
		$sql = "SELECT * FROM description WHERE user_id in (SELECT Id FROM user WHERE name LIKE '$us')";
		$result = mysqli_query($connect, $sql);

		if(mysqli_num_rows($result) > 0){
			echo "200"
		} else { echo "401"}
	}
?>