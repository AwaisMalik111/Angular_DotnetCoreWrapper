import { Injectable } from '@angular/core';
  
import { ToastrService } from 'ngx-toastr';
  
@Injectable({
  providedIn: 'root'
})
export class NotificationService {
  
  constructor(private toastr: ToastrService) { }
  
  showSuccess(message="test", title="test"){
      this.toastr.success(message, title)
  }
  
  showError(message="test", title="test"){
      this.toastr.error(message, title)
  }
  
  showInfo(message="test", title="test"){
      this.toastr.info(message, title)
  }
  
  showWarning(message="test", title="test"){
      this.toastr.warning(message, title)
  }
  
}