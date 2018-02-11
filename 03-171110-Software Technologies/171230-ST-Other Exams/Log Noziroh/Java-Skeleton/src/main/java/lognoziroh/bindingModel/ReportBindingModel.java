package lognoziroh.bindingModel;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;

public class ReportBindingModel {
	@NotNull
    private String status;

	@NotNull
    @Size(min=1)
	private String message;

    @NotNull
    @Size(min=1)
	private String origin;

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public String getOrigin() {
        return origin;
    }

    public void setOrigin(String origin) {
        this.origin = origin;
    }
}
