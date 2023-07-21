Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
File name: tiket2_api.php
<?php
require_once 'database.php';
require_once 'Tiket2.php';
$db = new MySQLDatabase();
$tiket2 = new Tiket2($db);
$id=0;
$Notiket=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['Notiket'])){
            $Notiket = $_GET['Notiket'];
        }
        if($id>0){    
            $result = $tiket2->get_by_id($id);
        }elseif($Notiket>0){
            $result = $tiket2->get_by_Notiket($Notiket);
        } else {
            $result = $tiket2->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new tiket2
        $tiket2->Notiket = $_POST['Notiket'];
        $tiket2->Nama = $_POST['Nama'];
        $tiket2->Nohp = $_POST['Nohp'];
        $tiket2->tujuan = $_POST['tujuan'];
        $tiket2->harga = $_POST['harga'];
       
        $tiket2->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Tiket2 created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Tiket2 not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['Notiket'])){
            $Notiket = $_GET['Notiket'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $tiket2->Notiket = $_PUT['Notiket'];
        $tiket2->Nama = $_PUT['Nama'];
        $tiket2->Nohp = $_PUT['Nohp'];
        $tiket2->tujuan = $_PUT['tujuan'];
        $tiket2->harga = $_PUT['harga'];
        if($id>0){    
            $tiket2->update($id);
        }elseif($Notiket<>""){
            $tiket2->update_by_Notiket($Notiket);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Tiket2 updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Tiket2 update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['Notiket'])){
            $Notiket = $_GET['Notiket'];
        }
        if($id>0){    
            $tiket2->delete($id);
        }elseif($Notiket>0){
            $tiket2->delete_by_Notiket($Notiket);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Tiket2 deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Tiket2 delete failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>