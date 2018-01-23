
<HTML>
    <HEAD>
        <TITLE>SuperaT</TITLE>

    </HEAD>
    <HEADER><H1> Estadisticas </H1></HEADER>
    <BODY>	
       <?php
			$server = "localhost";
			$user = "root";
			$pass = "";
			$database = "superat";

			$connect = new mysqli($server, $user, $pass, $database);

			if (!$connect) {
				echo "ERROR";
			} else {
				$sql = "SELECT * FROM description";
				$result = mysqli_query($connect, $sql);

				if(mysqli_num_rows($result) > 0){
					echo "200";
				} else { echo "401";}
			}
		?>
    </BODY>
</HTML>
