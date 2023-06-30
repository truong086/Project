/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.tienluong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface ITienLuongService {
    public boolean insert(tienluong tl) throws Exception;
    
    public boolean update(tienluong tl) throws Exception;
    
    public boolean delete(String tl) throws Exception;
    
    public List<tienluong> findAll() throws Exception;
    
    public List<tienluong> timkiem(String s) throws Exception;
    
    public tienluong findby(String s) throws Exception;
    
    public tienluong findbyid(int s) throws Exception;
}
