
<?php
//Simpanlah dengan nama file : Tb_kendaraan.php
require_once 'database.php';
class Tb_kendaraan 
{
    private $db;
    private $table = 'tb_kendaraan';
    public $nama = "";
    public $daya_angkut = "";
    public $harga = "";
    public $id_rute = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function get_by_nama(int $nama)
    {
        $query = "SELECT * FROM $this->table WHERE nama = $nama";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nama`,`daya_angkut`,`harga`,`id_rute`) VALUES ('$this->nama','$this->daya_angkut','$this->harga','$this->id_rute')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET nama = '$this->nama', daya_angkut = '$this->daya_angkut', harga = '$this->harga', id_rute = '$this->id_rute' 
        WHERE id_kendaraan = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_nama($nama): int
    {
        $query = "UPDATE $this->table SET nama = '$this->nama', daya_angkut = '$this->daya_angkut', harga = '$this->harga', id_rute = '$this->id_rute' 
        WHERE nama = $nama";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id_kendaraan = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_nama($nama): int
    {
        $query = "DELETE FROM $this->table WHERE nama = $nama";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>