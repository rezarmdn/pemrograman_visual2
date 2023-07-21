
<?php
//Simpanlah dengan nama file : Pemesanan.php
require_once 'database.php';
class Pemesanan 
{
    private $db;
    private $table = 'pemesanan';
    public $nama_pemesanan = "";
    public $email = "";
    public $no_hp = "";
    public $tanggal_lahir = "";
    public $bayar = "";
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
    public function get_by_nama_pemesanan(int $nama_pemesanan)
    {
        $query = "SELECT * FROM $this->table WHERE nama_pemesanan = $nama_pemesanan";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nama_pemesanan`,`email`,`no_hp`,`tanggal_lahir`,`bayar`) VALUES ('$this->nama_pemesanan','$this->email','$this->no_hp','$this->tanggal_lahir','$this->bayar')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET nama_pemesanan = '$this->nama_pemesanan', email = '$this->email', no_hp = '$this->no_hp', tanggal_lahir = '$this->tanggal_lahir', bayar = '$this->bayar' 
        WHERE id_pemesan = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_nama_pemesanan($nama_pemesanan): int
    {
        $query = "UPDATE $this->table SET nama_pemesanan = '$this->nama_pemesanan', email = '$this->email', no_hp = '$this->no_hp', tanggal_lahir = '$this->tanggal_lahir', bayar = '$this->bayar' 
        WHERE nama_pemesanan = $nama_pemesanan";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id_pemesan = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_nama_pemesanan($nama_pemesanan): int
    {
        $query = "DELETE FROM $this->table WHERE nama_pemesanan = $nama_pemesanan";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>