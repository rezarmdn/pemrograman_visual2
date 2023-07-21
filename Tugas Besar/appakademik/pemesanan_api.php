Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
File name: pemesanan_api.php
<?php
require_once 'database.php';
require_once 'Pemesanan.php';
$db = new MySQLDatabase();
$pemesanan = new Pemesanan($db);
$id=0;
$nama_pemesanan=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nama_pemesanan'])){
            $nama_pemesanan = $_GET['nama_pemesanan'];
        }
        if($id>0){    
            $result = $pemesanan->get_by_id($id);
        }elseif($nama_pemesanan>0){
            $result = $pemesanan->get_by_nama_pemesanan($nama_pemesanan);
        } else {
            $result = $pemesanan->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new pemesanan
        $pemesanan->nama_pemesanan = $_POST['nama_pemesanan'];
        $pemesanan->email = $_POST['email'];
        $pemesanan->no_hp = $_POST['no_hp'];
        $pemesanan->tanggal_lahir = $_POST['tanggal_lahir'];
        $pemesanan->bayar = $_POST['bayar'];
       
        $pemesanan->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pemesanan created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pemesanan not created.';
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
        if(isset($_GET['nama_pemesanan'])){
            $nama_pemesanan = $_GET['nama_pemesanan'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $pemesanan->nama_pemesanan = $_PUT['nama_pemesanan'];
        $pemesanan->email = $_PUT['email'];
        $pemesanan->no_hp = $_PUT['no_hp'];
        $pemesanan->tanggal_lahir = $_PUT['tanggal_lahir'];
        $pemesanan->bayar = $_PUT['bayar'];
        if($id>0){    
            $pemesanan->update($id);
        }elseif($nama_pemesanan<>""){
            $pemesanan->update_by_nama_pemesanan($nama_pemesanan);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pemesanan updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pemesanan update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nama_pemesanan'])){
            $nama_pemesanan = $_GET['nama_pemesanan'];
        }
        if($id>0){    
            $pemesanan->delete($id);
        }elseif($nama_pemesanan>0){
            $pemesanan->delete_by_nama_pemesanan($nama_pemesanan);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pemesanan deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pemesanan delete failed.';
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